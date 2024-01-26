using System;

class Program
{
    static void Main(string[] args)
    {
        // Simulate velocity detection
        double velocity = 50; // Example velocity (in meters per second)

        // Check for high velocity
        CheckForHighVelocity(velocity);
    }

    static void CheckForHighVelocity(double velocity)
    {
        double threshold = 40; // Threshold velocity for warning (in meters per second)

        if (velocity > threshold)
        {
            Console.WriteLine("Warning: High Velocity Detected!");
            Console.WriteLine($"Current Velocity: {velocity} m/s");
            Console.WriteLine("Take necessary precautions to ensure safety.");
        }
        else
        {
            Console.WriteLine("Velocity is within safe range.");
        }
    }
}
