public class StretchingActivity : Activity
{
    private List<string> _stretches = new List<string>
    {
        "Neck Rolls: Slowly roll your head in a circle.",
        "Shoulder Rolls: Shrug your shoulders up and roll them back and down.",
        "Wrist Stretch: Hold your hand out and gently pull your fingers back.",
        "Torso Twist: Twist your upper body to one side, then the other.",
        "Stand and Reach: Stand tall and reach both arms overhead.",
        "Hamstring Stretch: Touch your toes while standing, knees slightly bent.",
        "Chest Opener: Clasp your hands behind your back and lift your chest."
    };

    public StretchingActivity() : base("Stretching Activity", "This activity will guide you through some simple physical stretches you can do at your desk or standing nearby.")
    { }

    public void Run()
    {
        DisplayStartingMessage();
        Random rand = new Random();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.WriteLine($"\n> {GetRandomStretch(rand)}");
            ShowCountdown(5);
        }
        DisplayEndingMessage();
    }

    private string GetRandomStretch(Random rand)
    {
        return _stretches[rand.Next(_stretches.Count)];
    }
}