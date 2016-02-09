using System;

namespace NextteamBr
{
    public class Game
    {
        public bool connected { get; set; }
        public bool paused { get; set; }
        public string time { get; set; }
        public double timeScale { get; set; }
        public string nextRestStopTime { get; set; }
        public string version { get; set; }
        public string telemetryPluginVersion { get; set; }
    }

    public class Placement
    {
        public double x { get; set; }
        public double y { get; set; }
        public double z { get; set; }
        public double heading { get; set; }
        public double pitch { get; set; }
        public double roll { get; set; }
    }

    public class Acceleration
    {
        public double x { get; set; }
        public double y { get; set; }
        public double z { get; set; }
    }

    public class Head
    {
        public double x { get; set; }
        public double y { get; set; }
        public double z { get; set; }
    }

    public class Cabin
    {
        public double x { get; set; }
        public double y { get; set; }
        public double z { get; set; }
    }

    public class Hook
    {
        public double x { get; set; }
        public double y { get; set; }
        public double z { get; set; }
    }

    public class Truck
    {
        public string id { get; set; }
        public string make { get; set; }
        public string model { get; set; }
        public double speed { get; set; }
        public double cruiseControlSpeed { get; set; }
        public bool cruiseControlOn { get; set; }
        public double odometer { get; set; }
        public int gear { get; set; }
        public int displayedGear { get; set; }
        public int forwardGears { get; set; }
        public int reverseGears { get; set; }
        public string shifterType { get; set; }
        public double engineRpm { get; set; }
        public double engineRpmMax { get; set; }
        public double fuel { get; set; }
        public double fuelCapacity { get; set; }
        public double fuelAverageConsumption { get; set; }
        public double fuelWarningFactor { get; set; }
        public bool fuelWarningOn { get; set; }
        public double wearEngine { get; set; }
        public double wearTransmission { get; set; }
        public double wearCabin { get; set; }
        public double wearChassis { get; set; }
        public double wearWheels { get; set; }
        public double userSteer { get; set; }
        public double userThrottle { get; set; }
        public double userBrake { get; set; }
        public double userClutch { get; set; }
        public double gameSteer { get; set; }
        public double gameThrottle { get; set; }
        public double gameBrake { get; set; }
        public double gameClutch { get; set; }
        public int shifterSlot { get; set; }
        public bool engineOn { get; set; }
        public bool electricOn { get; set; }
        public bool wipersOn { get; set; }
        public int retarderBrake { get; set; }
        public int retarderStepCount { get; set; }
        public bool parkBrakeOn { get; set; }
        public bool motorBrakeOn { get; set; }
        public double brakeTemperature { get; set; }
        public double adblue { get; set; }
        public double adblueCapacity { get; set; }
        public double adblueAverageConsumpton { get; set; }
        public bool adblueWarningOn { get; set; }
        public double airPressure { get; set; }
        public bool airPressureWarningOn { get; set; }
        public double airPressureWarningValue { get; set; }
        public bool airPressureEmergencyOn { get; set; }
        public double airPressureEmergencyValue { get; set; }
        public double oilTemperature { get; set; }
        public double oilPressure { get; set; }
        public bool oilPressureWarningOn { get; set; }
        public double oilPressureWarningValue { get; set; }
        public double waterTemperature { get; set; }
        public bool waterTemperatureWarningOn { get; set; }
        public double waterTemperatureWarningValue { get; set; }
        public double batteryVoltage { get; set; }
        public bool batteryVoltageWarningOn { get; set; }
        public double batteryVoltageWarningValue { get; set; }
        public double lightsDashboardValue { get; set; }
        public bool lightsDashboardOn { get; set; }
        public bool blinkerLeftActive { get; set; }
        public bool blinkerRightActive { get; set; }
        public bool blinkerLeftOn { get; set; }
        public bool blinkerRightOn { get; set; }
        public bool lightsParkingOn { get; set; }
        public bool lightsBeamLowOn { get; set; }
        public bool lightsBeamHighOn { get; set; }
        public bool lightsAuxFrontOn { get; set; }
        public bool lightsAuxRoofOn { get; set; }
        public bool lightsBeaconOn { get; set; }
        public bool lightsBrakeOn { get; set; }
        public bool lightsReverseOn { get; set; }
        public Placement placement { get; set; }
        public Acceleration acceleration { get; set; }
        public Head head { get; set; }
        public Cabin cabin { get; set; }
        public Hook hook { get; set; }
    }

    public class Placement2
    {
        public double x { get; set; }
        public double y { get; set; }
        public double z { get; set; }
        public double heading { get; set; }
        public double pitch { get; set; }
        public double roll { get; set; }
    }

    public class Trailer
    {
        public bool attached { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public double mass { get; set; }
        public double wear { get; set; }
        public Placement2 placement { get; set; }
    }

    public class Job
    {
        public int income { get; set; }
        public string deadlineTime { get; set; }
        public string remainingTime { get; set; }
        public string sourceCity { get; set; }
        public string sourceCompany { get; set; }
        public string destinationCity { get; set; }
        public string destinationCompany { get; set; }
    }

    public class Navigation
    {
        public string estimatedTime { get; set; }
        public int estimatedDistance { get; set; }
        public int speedLimit { get; set; }
    }

    public class RootObject
    {
        public Game game { get; set; }
        public Truck truck { get; set; }
        public Trailer trailer { get; set; }
        public Job job { get; set; }
        public Navigation navigation { get; set; }
    }
}
