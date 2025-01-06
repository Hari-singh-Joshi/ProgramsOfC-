using System;

class Publisher
{
    // Define a delegate
    public delegate void Notify(string message);

    // Define an event based on the delegate
    public event Notify OnNotify;

    // Method to trigger the event
    public void TriggerEvent(string message)
    {
        if (OnNotify != null)
        {
            OnNotify(message); // Call all subscribed methods
        }
        else
        {
            Console.WriteLine("No subscribers for the event.");
        }
    }
}

class Subscriber
{
    public void ShowMessage(string message)
    {
        Console.WriteLine($"Message received: {message}");
    }

    public void LogMessage(string message)
    {
        Console.WriteLine($"Logging: {message}");
    }
}

class Program
{
    static void Main()
    {
        Publisher publisher = new Publisher();
        Subscriber subscriber = new Subscriber();

        // Subscribe methods to the event
        publisher.OnNotify += subscriber.ShowMessage;
        publisher.OnNotify += subscriber.LogMessage;

        // Trigger the event
        publisher.TriggerEvent("Hello, Multicast Delegate and Event!");

        // Unsubscribe one method
        publisher.OnNotify -= subscriber.LogMessage;

        // Trigger the event again
        publisher.TriggerEvent("Second message after unsubscribing.");
    }
}
