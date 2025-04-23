class Program
{
    static void Main(string[] args)
    {
        // Display the ASCII Art logo for Cyber Security Awareness
        DisplayAsciiLogo();

        // Play a greeting voice message
        PlayGreeting("greeting.wav");

        // Greet the user and get their name
        string userName = GetUserName();

        // Display personalized greeting
        Console.WriteLine($"\nHello, {userName}! Welcome to the Cyber Security Awareness Bot.\n");

        // Start interacting with the user
        StartChatbotInteraction();
    }

    // Display ASCII logo
    static void DisplayAsciiLogo()
    {
        string asciiLogo = @"
  _____ _               _____             _____        __  __          
 / ____| |             / ____|           / ____|      |  \/  |         
| |    | |__   __ _ _ _| |__ _   _ _ __  | |     ___  | \  / | ___ _ __  
| |    | '_ \ / _` | '_ \ __| | | | '_ \ | |    / _ \ | |\/| |/ _ \ '__| 
| |____| | | | (_| | | | | |_| |_| | | | || |___|  __/ | |  | |  __/ |    
 \_____|_| |_|\__,_|_|  \__|\__,_|_| |_|  \_____\___| |_|  |_|\___|_|    
                                                                          
                                                                          
";

        // Print the ASCII art
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(asciiLogo);
        Console.ResetColor();
    }

    // Play the greeting audio
    static void PlayGreeting(string filePath)
    {
        try
        {
            using (var player = new SoundPlayer(filePath))
            {
                player.PlaySync();  // Play the WAV file synchronously
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error playing greeting: {ex.Message}");
        }
    }

    // Get user's name
    static string GetUserName()
    {
        string name = string.Empty;

        while (string.IsNullOrWhiteSpace(name))
        {
            Console.Write("Please enter your name: ");
            name = Console.ReadLine()?.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Name cannot be empty. Please try again.");
            }
        }

        return name;
    }

    // Start chatbot interaction
    static void StartChatbotInteraction()
    {
        bool continueChat = true;
        while (continueChat)
        {
            Console.WriteLine("\nAsk me anything about Cyber Security:");
            string userQuery = Console.ReadLine()?.ToLower().Trim();

            if (string.IsNullOrWhiteSpace(userQuery))
            {
                Console.WriteLine("\nI didn't quite understand that. Could you rephrase?");
                continue;
            }

            // Respond to user queries
            if (userQuery.Contains("how are you"))
            {
                Console.WriteLine("I'm just a bot, but thanks for asking! How can I help you with cyber security?");
            }
            else if (userQuery.Contains("what's your purpose"))
            {
                Console.WriteLine("My purpose is to help you understand cyber security, including topics like password safety, phishing, and safe browsing.");
            }
            else if (userQuery.Contains("what can i ask you about"))
            {
                Console.WriteLine("You can ask me about password safety, phishing attacks, safe browsing practices, and how to protect yourself online.");
            }
            else if (userQuery.Contains("password safety"))
            {
                Console.WriteLine("Password safety is crucial. Always use strong, unique passwords for each account, and consider using a password manager.");
            }
            else if (userQuery.Contains("phishing"))
            {
                Console.WriteLine("Phishing is a type of online scam where attackers try to trick you into giving them your personal information. Always be cautious when clicking on links or opening attachments in emails.");
            }
            else if (userQuery.Contains("safe browsing"))
            {
                Console.WriteLine("Safe browsing involves avoiding suspicious websites, ensuring that sites are secure (look for HTTPS), and being wary of pop-up ads and unsolicited downloads.");
            }
            else
            {
                Console.WriteLine("I didn't quite understand that. Could you ask something else about cyber security?");
            }

            // Ask if the user wants to continue
            Console.WriteLine("\nDo you want to ask anything else? (yes/no): ");
            string continueResponse = Console.ReadLine()?.ToLower().Trim();
            if (continueResponse != "yes")
            {
                continueChat = false;
                Console.WriteLine("\nThank you for chatting! Stay safe online.");
            }
        }
    }
}

internal class SoundPlayer : IDisposable
{
    private string filePath;

    public SoundPlayer(string filePath)
    {
        this.filePath = filePath;
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }

    internal void PlaySync()
    {
        throw new NotImplementedException();
    }
}

//testing workflow