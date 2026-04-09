using System;

namespace PROGPART1
{
    public class Chatbot//Main chatbot class that handles user interaction and responses
    {
        private string userName;
        public void Start()
        {
            PlayIntro();
            GetUserName();
            GreetUser();
            RunChat();

        }
        private void PlayIntro()//Plays the greeting sound and displays the ASCII art when the chatbot starts
        {
            AudioPlayer.PlayGreeting();
            UIHelper.DisplayAscii();
        }

        private void GetUserName()
        {
            Console.Write("\nEnter your name: ");
            userName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(userName))
            {
                userName = "User";
            }
        }

        private void GreetUser()//Greets the user with a personalized message
        {
            UIHelper.TypeText($"\nHello, {userName}! I'm your Cybersecurity Assistant.\n");//user input, chatbot response
        }

        private void RunChat()//Main chat loop that processes user input and generates responses
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"\n{userName}: ");
                Console.ResetColor();

                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("⚠️ Please enter something.")
                    continue;
                }

                if (input.ToLower() == "exit")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    UIHelper.TypeText("CyberBot: Goodbye! Stay safe 🔐");
                    Console.ResetColor();
                    break;
                }

                string response = GetResponse(input.ToLower());

                Console.ForegroundColor = ConsoleColor.Cyan;
                UIHelper.TypeText($"CyberBot: {response}");
                Console.ResetColor();
            }
        }

        // 🔥 KEYWORD + SPLIT LOGIC
        private string GetResponse(string input)//Generates responses based on keywords found in the user input
        {
            string[] keywords = { "how", "purpose", "ask", "password", "phishing", "browsing","cybersecurity","Malware" };

            string[] responses =
            {
            "I'm doing great! Thanks for asking 😄",
            "My purpose is to help you stay safe online.",
            "You can ask about Password Safety, Phishing, and Safe Browsing.",
            "Use strong passwords with letters, numbers, and symbols. Never reuse them.",
            "Phishing is when attackers trick you into giving personal info. Always verify links.",
            "Safe browsing means using secure websites (https) and avoiding suspicious downloads.",
            "Cybersecurity is crucial to protect your data and privacy online.",
            "Malware is any program or code designed to harm",
        };

            string[] words = input.Split(' ');
            bool found = false;

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < keywords.Length; j++)
                {
                    if (words[i].Contains(keywords[j]))
                    {
                        found = true;
                        return responses[j];
                    }
                }
            }

            return "I didn't quite understand that. Try asking about cybersecurity topics.";//Default response if no keywords are found
                ;
        }
    }
}
