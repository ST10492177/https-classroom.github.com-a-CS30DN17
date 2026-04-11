using System;
using System.Collections.Generic;

namespace ai_chatapp
{
    public class Chat
    {
        public void StartChat()
        {
            string username = GetUsername();
            Console.WriteLine($"\nWelcome to our cyber awareness bot, {username}!");
            ChatLoop(username);
        }

        private string GetUsername()
        {
            Console.Write("Please enter your username: ");
            string username = Console.ReadLine()?.Trim();

            if (string.IsNullOrEmpty(username))
            {
                username = "User";
            }

            return username;
        }

        public void ChatLoop(string username)
        {
            Dictionary<string, string> botResponses = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "how are you", "I'm doing great! Thanks for asking 😊" },
                { "purpose", "My purpose is to help you understand cybersecurity and stay safe online." },
                { "phishing", "Phishing is a scam where attackers trick you into giving personal information through fake emails or websites." },
                { "malware", "Malware is harmful software designed to damage or steal data from your device." },
                { "virus", "A virus is a type of malware that spreads and damages files on your computer." },
                { "ransomware", "Ransomware locks your files and demands payment to unlock them." },
                { "spyware", "Spyware secretly collects your personal information without your permission." },
                { "adware", "Adware displays unwanted advertisements and may track your activity." },
                { "trojan", "A Trojan is malware disguised as safe software to trick users into installing it." },
                { "worm", "A worm spreads automatically across networks without user interaction." },
                { "firewall", "A firewall protects your system by controlling incoming and outgoing network traffic." },
                { "vpn", "A VPN hides your IP address and encrypts your internet connection." },
                { "encryption", "Encryption converts data into a secure format that only authorized users can read." },
                { "2fa", "2FA adds extra security by requiring a second verification step." },
                { "password", "A password is a secret key used to access accounts securely." },
                { "hacking", "Hacking is gaining unauthorized access to systems or data." },
                { "social engineering", "Social engineering tricks people into giving away confidential information." },
                { "data breach", "A data breach is when sensitive information is exposed or stolen." },
                { "cyber attack", "A cyber attack is an attempt to damage or access systems illegally." },
                { "ddos", "A DDoS attack floods a system to make it unavailable." },
                { "antivirus", "Antivirus software detects and removes malware." },
                { "ip address", "An IP address is a unique number that identifies a device on a network." },
                { "mac address", "A MAC address is a unique identifier assigned to a network device." },
                { "https", "HTTPS encrypts communication between your browser and websites." },
                { "stay safe", "Use strong passwords, avoid suspicious links, and keep software updated." },
                { "protect data", "Protect data using encryption, backups, and secure passwords." },
                { "cloud security", "Cloud security protects data stored online." },
                { "password manager", "A password manager stores and generates secure passwords." }
            };

            Console.WriteLine("\n(Type 'exit' to quit)\n");

            while (true)
            {
                Console.Write($"{username}: ");
                string input = Console.ReadLine()?.Trim().ToLower();

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Bot: Please enter something.");
                    continue;
                }

                if (input == "exit")
                {
                    Console.WriteLine($"Bot: Goodbye {username}! 👋");
                    break;
                }

                bool found = false;

                foreach (var item in botResponses)
                {
                    if (input.Contains(item.Key))
                    {
                        Console.WriteLine($"Bot: {item.Value}");
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    Console.WriteLine("Bot: I don't understand. Ask me something about cybersecurity 😊");
                }
            }
        }
    }
}