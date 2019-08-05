﻿using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LugNutzEnterprize.Models
{
    public class Vehicle
    {
        [Key]
        public int VehicleId { get; set; }
        [Required]
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        [Required]
        public int VehicleMileage { get; set; }

        [Display(Name = "Image Path")]
        public string ImagePath { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }

        [NotMapped]
        [Display(Name = "Vehicle Name")]
        public string FullName
        {
            get
            {
                return ModelYear + " " + Make + " " + Model;
            }
        }
        public string ABS { get; set; }
        public string ActiveSafetySysNote { get; set; }
        public string AdaptiveCruiseControl { get; set; }
        public string AdaptiveDrivingBeam { get; set; }
        public string AdaptiveHeadlights { get; set; }
        public string AdditionalErrorText { get; set; }
        public string AirBagLocCurtain { get; set; }
        public string AirBagLocFront { get; set; }
        public string AirBagLocKnee { get; set; }
        public string AirBagLocSeatCushion { get; set; }
        public string AirBagLocSide { get; set; }
        public string AutoReverseSystem { get; set; }
        public string AutomaticPedestrianAlertingSound { get; set; }
        public string AxleConfiguration { get; set; }
        public string Axles { get; set; }
        public string BasePrice { get; set; }
        public string BatteryA { get; set; }
        public string BatteryA_to { get; set; }
        public string BatteryCells { get; set; }
        public string BatteryInfo { get; set; }
        public string BatteryKWh { get; set; }
        public string BatteryKWh_to { get; set; }
        public string BatteryModules { get; set; }
        public string BatteryPacks { get; set; }
        public string BatteryType { get; set; }
        public string BatteryV { get; set; }
        public string BatteryV_to { get; set; }
        public string BedLengthIN { get; set; }
        public string BedType { get; set; }
        public string BlindSpotMon { get; set; }
        public string BodyCabType { get; set; }
        public string BodyClass { get; set; }
        public string BrakeSystemDesc { get; set; }
        public string BrakeSystemType { get; set; }
        public string BusFloorConfigType { get; set; }
        public string BusLength { get; set; }
        public string BusType { get; set; }
        public string CAN_AACN { get; set; }
        public string CIB { get; set; }
        public string CashForClunkers { get; set; }
        public string ChargerLevel { get; set; }
        public string ChargerPowerKW { get; set; }
        public string CoolingType { get; set; }
        public string CurbWeightLB { get; set; }
        public string CustomMotorcycleType { get; set; }
        public string DaytimeRunningLight { get; set; }
        public string DestinationMarket { get; set; }
        public string DisplacementCC { get; set; }
        public string DisplacementCI { get; set; }
        public string DisplacementL { get; set; }
        public string Doors { get; set; }
        public string DriveType { get; set; }
        public string DriverAssist { get; set; }
        public string DynamicBrakeSupport { get; set; }
        public string EDR { get; set; }
        public string ESC { get; set; }
        public string EVDriveUnit { get; set; }
        public string ElectrificationLevel { get; set; }
        public string EngineConfiguration { get; set; }
        public string EngineCycles { get; set; }
        public string EngineCylinders { get; set; }
        public string EngineHP { get; set; }
        public string EngineHP_to { get; set; }
        public string EngineKW { get; set; }
        public string EngineManufacturer { get; set; }
        public string EngineModel { get; set; }
        public string EntertainmentSystem { get; set; }
        public string ErrorCode { get; set; }
        public string ErrorText { get; set; }
        public string ForwardCollisionWarning { get; set; }
        public string FuelInjectionType { get; set; }
        public string FuelTypePrimary { get; set; }
        public string FuelTypeSecondary { get; set; }
        public string GCWR { get; set; }
        public string GCWR_to { get; set; }
        public string GVWR { get; set; }
        public string GVWR_to { get; set; }
        public string KeylessIgnition { get; set; }
        public string LaneDepartureWarning { get; set; }
        public string LaneKeepSystem { get; set; }
        public string LowerBeamHeadlampLightSource { get; set; }
        [Required]
        public string Make { get; set; }
        public string Manufacturer { get; set; }
        public string ManufacturerId { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public string ModelYear { get; set; }
        public string MotorcycleChassisType { get; set; }
        public string MotorcycleSuspensionType { get; set; }
        public string NCSABodyType { get; set; }
        public string NCSAMake { get; set; }
        public string NCSAMapExcApprovedBy { get; set; }
        public string NCSAMapExcApprovedOn { get; set; }
        public string NCSAMappingException { get; set; }
        public string NCSAModel { get; set; }
        public string NCSANote { get; set; }
        public string Note { get; set; }
        public string OtherBusInfo { get; set; }
        public string OtherEngineInfo { get; set; }
        public string OtherMotorcycleInfo { get; set; }
        public string OtherRestraintSystemInfo { get; set; }
        public string OtherTrailerInfo { get; set; }
        public string ParkAssist { get; set; }
        public string PedestrianAutomaticEmergencyBraking { get; set; }
        public string PlantCity { get; set; }
        public string PlantCompanyName { get; set; }
        public string PlantCountry { get; set; }
        public string PlantState { get; set; }
        public string PossibleValues { get; set; }
        public string Pretensioner { get; set; }
        public string RearCrossTrafficAlert { get; set; }
        public string RearVisibilitySystem { get; set; }
        public string SAEAutomationLevel { get; set; }
        public string SAEAutomationLevel_to { get; set; }
        public string SeatBeltsAll { get; set; }
        public string SeatRows { get; set; }
        public string Seats { get; set; }
        public string SemiautomaticHeadlampBeamSwitching { get; set; }
        public string Series { get; set; }
        public string Series2 { get; set; }
        public string SteeringLocation { get; set; }
        public string SuggestedVIN { get; set; }
        public string TPMS { get; set; }
        public string TopSpeedMPH { get; set; }
        public string TrackWidth { get; set; }
        public string TractionControl { get; set; }
        public string TrailerBodyType { get; set; }
        public string TrailerLength { get; set; }
        public string TrailerType { get; set; }
        public string TransmissionSpeeds { get; set; }
        public string TransmissionStyle { get; set; }
        public string Trim { get; set; }
        public string Trim2 { get; set; }
        public string Turbo { get; set; }
        public string VIN { get; set; }
        public string ValveTrainDesign { get; set; }
        public string VehicleType { get; set; }
        public string WheelBaseLong { get; set; }
        public string WheelBaseShort { get; set; }
        public string WheelBaseType { get; set; }
        public string WheelSizeFront { get; set; }
        public string WheelSizeRear { get; set; }
        public string Wheels { get; set; }
        public string Windows { get; set; }

        public static implicit operator Vehicle(string v)
        {
            throw new NotImplementedException();
        }
    }
}

