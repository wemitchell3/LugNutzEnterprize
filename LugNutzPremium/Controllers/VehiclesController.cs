using LugNutzPremium.Data;
using LugNutzPremium.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace LugNutzPremium.Controllers
{
    [Authorize]
    public class VehiclesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IHostingEnvironment hostingEnvironment;

        public VehiclesController(ApplicationDbContext context, UserManager<ApplicationUser> userManager, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            _userManager = userManager;
            this.hostingEnvironment = hostingEnvironment;
        }

        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);

        // GET: Vehicles
        public async Task<IActionResult> Index()
        {
            var currentUser = await GetCurrentUserAsync();
            var applicationDbContext = await _context.Vehicle.Include(v => v.User).Where(v => v.UserId == currentUser.Id).ToListAsync();            
            return View(applicationDbContext);         
        }

        // GET: Vehicles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vehicle = await _context.Vehicle
                .FirstOrDefaultAsync(m => m.VehicleId == id);
            if (vehicle == null)
            {
                return NotFound();
            }

            return View(vehicle);
        }

        // GET: Vehicles/Create
        public IActionResult Create()
        {
            return View();
        }

        // GET: Vehicles/CreateManually
        public IActionResult CreateManually()
        {
            return View();
        }

        // GET: Vehicles/CreateManually
        public IActionResult CreateAutomaticallyVin()
        {
            return View();
        }

        // GET: Vehicles/CreateAutomaticallyVin
        public async Task<IActionResult> ApiGet(Vehicle vehicle)
        {
            string url = $"https://vpic.nhtsa.dot.gov/api/vehicles/decodevinvalues/{vehicle.VIN}?format=json";


            HttpClient httpClient = new HttpClient
            {
                BaseAddress = new Uri(url)
            };
            HttpClient client = httpClient;

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            try
            {
                var response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var v = await response.Content.ReadAsAsync<Rootobject>();
                    foreach (var mileage in v.Results)
                    {
                        mileage.VehicleMileage = vehicle.VehicleMileage;

                    }
                    return View(v.Results[0]);
                }
                return View();
            }
            catch
            {
                return NotFound();
            }
        }


        // POST: Vehicles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateConfirmed([Bind("VehicleId,UserId,VehicleMileage,Photo,ImagePath,ABS,ActiveSafetySysNote,AdaptiveCruiseControl,AdaptiveDrivingBeam,AdaptiveHeadlights,AdditionalErrorText,AirBagLocCurtain,AirBagLocFront,AirBagLocKnee,AirBagLocSeatCushion,AirBagLocSide,AutoReverseSystem,AutomaticPedestrianAlertingSound,AxleConfiguration,Axles,BasePrice,BatteryA,BatteryA_to,BatteryCells,BatteryInfo,BatteryKWh,BatteryKWh_to,BatteryModules,BatteryPacks,BatteryType,BatteryV,BatteryV_to,BedLengthIN,BedType,BlindSpotMon,BodyCabType,BodyClass,BrakeSystemDesc,BrakeSystemType,BusFloorConfigType,BusLength,BusType,CAN_AACN,CIB,CashForClunkers,ChargerLevel,ChargerPowerKW,CoolingType,CurbWeightLB,CustomMotorcycleType,DaytimeRunningLight,DestinationMarket,DisplacementCC,DisplacementCI,DisplacementL,Doors,DriveType,DriverAssist,DynamicBrakeSupport,EDR,ESC,EVDriveUnit,ElectrificationLevel,EngineConfiguration,EngineCycles,EngineCylinders,EngineHP,EngineHP_to,EngineKW,EngineManufacturer,EngineModel,EntertainmentSystem,ErrorCode,ErrorText,ForwardCollisionWarning,FuelInjectionType,FuelTypePrimary,FuelTypeSecondary,GCWR,GCWR_to,GVWR,GVWR_to,KeylessIgnition,LaneDepartureWarning,LaneKeepSystem,LowerBeamHeadlampLightSource,Make,Manufacturer,ManufacturerId,Model,ModelYear,MotorcycleChassisType,MotorcycleSuspensionType,NCSABodyType,NCSAMake,NCSAMapExcApprovedBy,NCSAMapExcApprovedOn,NCSAMappingException,NCSAModel,NCSANote,Note,OtherBusInfo,OtherEngineInfo,OtherMotorcycleInfo,OtherRestraintSystemInfo,OtherTrailerInfo,ParkAssist,PedestrianAutomaticEmergencyBraking,PlantCity,PlantCompanyName,PlantCountry,PlantState,PossibleValues,Pretensioner,RearCrossTrafficAlert,RearVisibilitySystem,SAEAutomationLevel,SAEAutomationLevel_to,SeatBeltsAll,SeatRows,Seats,SemiautomaticHeadlampBeamSwitching,Series,Series2,SteeringLocation,SuggestedVIN,TPMS,TopSpeedMPH,TrackWidth,TractionControl,TrailerBodyType,TrailerLength,TrailerType,TransmissionSpeeds,TransmissionStyle,Trim,Trim2,Turbo,VIN,ValveTrainDesign,VehicleType,WheelBaseLong,WheelBaseShort,WheelBaseType,WheelSizeFront,WheelSizeRear,Wheels,Windows")] Vehicle vehicle)
        {
            ModelState.Remove("UserId");
            if (ModelState.IsValid)
            {
                string uniqueFileName = null;

                // If the Photo property on the incoming model object is not null, then the user has selected an image to upload.
                if (vehicle.Photo != null)
                {
                    // The image must be uploaded to the images folder in wwwroot. To get the path of the wwwroot folder we are using the inject HostingEnvironment service provided by ASP.NET Core
                    string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
                    // To make sure the file name is unique we are appending a new GUID value and and an underscore to the file name
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + vehicle.Photo.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    // Use CopyTo() method provided by IFormFile interface to copy the file to wwwroot/images folder
                    vehicle.Photo.CopyTo(new FileStream(filePath, FileMode.Create));
                    vehicle.ImagePath = uniqueFileName;
                }
                var currentUser = await GetCurrentUserAsync();
                vehicle.UserId = currentUser.Id;
                _context.Add(vehicle);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction(nameof(CreateAutomaticallyVin));
        }

        // GET: Vehicles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vehicle = await _context.Vehicle.FindAsync(id);
            if (vehicle == null)
            {
                return NotFound();
            }
            return View(vehicle);
        }

        // POST: Vehicles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("VehicleId,UserId,VehicleMileage,Photo,ImagePath,ABS,ActiveSafetySysNote,AdaptiveCruiseControl,AdaptiveDrivingBeam,AdaptiveHeadlights,AdditionalErrorText,AirBagLocCurtain,AirBagLocFront,AirBagLocKnee,AirBagLocSeatCushion,AirBagLocSide,AutoReverseSystem,AutomaticPedestrianAlertingSound,AxleConfiguration,Axles,BasePrice,BatteryA,BatteryA_to,BatteryCells,BatteryInfo,BatteryKWh,BatteryKWh_to,BatteryModules,BatteryPacks,BatteryType,BatteryV,BatteryV_to,BedLengthIN,BedType,BlindSpotMon,BodyCabType,BodyClass,BrakeSystemDesc,BrakeSystemType,BusFloorConfigType,BusLength,BusType,CAN_AACN,CIB,CashForClunkers,ChargerLevel,ChargerPowerKW,CoolingType,CurbWeightLB,CustomMotorcycleType,DaytimeRunningLight,DestinationMarket,DisplacementCC,DisplacementCI,DisplacementL,Doors,DriveType,DriverAssist,DynamicBrakeSupport,EDR,ESC,EVDriveUnit,ElectrificationLevel,EngineConfiguration,EngineCycles,EngineCylinders,EngineHP,EngineHP_to,EngineKW,EngineManufacturer,EngineModel,EntertainmentSystem,ErrorCode,ErrorText,ForwardCollisionWarning,FuelInjectionType,FuelTypePrimary,FuelTypeSecondary,GCWR,GCWR_to,GVWR,GVWR_to,KeylessIgnition,LaneDepartureWarning,LaneKeepSystem,LowerBeamHeadlampLightSource,Make,Manufacturer,ManufacturerId,Model,ModelYear,MotorcycleChassisType,MotorcycleSuspensionType,NCSABodyType,NCSAMake,NCSAMapExcApprovedBy,NCSAMapExcApprovedOn,NCSAMappingException,NCSAModel,NCSANote,Note,OtherBusInfo,OtherEngineInfo,OtherMotorcycleInfo,OtherRestraintSystemInfo,OtherTrailerInfo,ParkAssist,PedestrianAutomaticEmergencyBraking,PlantCity,PlantCompanyName,PlantCountry,PlantState,PossibleValues,Pretensioner,RearCrossTrafficAlert,RearVisibilitySystem,SAEAutomationLevel,SAEAutomationLevel_to,SeatBeltsAll,SeatRows,Seats,SemiautomaticHeadlampBeamSwitching,Series,Series2,SteeringLocation,SuggestedVIN,TPMS,TopSpeedMPH,TrackWidth,TractionControl,TrailerBodyType,TrailerLength,TrailerType,TransmissionSpeeds,TransmissionStyle,Trim,Trim2,Turbo,VIN,ValveTrainDesign,VehicleType,WheelBaseLong,WheelBaseShort,WheelBaseType,WheelSizeFront,WheelSizeRear,Wheels,Windows")] Vehicle vehicle)
        {
            if (id != vehicle.VehicleId)
            {
                return NotFound();
            }

            var currentUser = await GetCurrentUserAsync();
            ModelState.Remove("UserId");
            if (ModelState.IsValid)
            {
                try
                {
                    string uniqueFileName = null;

                    // If the Photo property on the incoming model object is not null, then the user has selected an image to upload.
                    if (vehicle.Photo != null)
                    {
                        // The image must be uploaded to the images folder in wwwroot. To get the path of the wwwroot folder we are using the inject HostingEnvironment service provided by ASP.NET Core
                        string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
                        // To make sure the file name is unique we are appending a new GUID value and and an underscore to the file name
                        uniqueFileName = Guid.NewGuid().ToString() + "_" + vehicle.Photo.FileName;
                        string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                        // Use CopyTo() method provided by IFormFile interface to copy the file to wwwroot/images folder
                        vehicle.Photo.CopyTo(new FileStream(filePath, FileMode.Create));
                        vehicle.ImagePath = uniqueFileName;
                    }
                    vehicle.UserId = currentUser.Id;
                    _context.Update(vehicle);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VehicleExists(vehicle.VehicleId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(vehicle);
        }

        // GET: Vehicles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vehicle = await _context.Vehicle
                .FirstOrDefaultAsync(m => m.VehicleId == id);
            if (vehicle == null)
            {
                return NotFound();
            }

            return View(vehicle);
        }

        // POST: Vehicles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vehicle = await _context.Vehicle.FindAsync(id);
            _context.Vehicle.Remove(vehicle);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VehicleExists(int id)
        {
            return _context.Vehicle.Any(e => e.VehicleId == id);
        }
    }
}