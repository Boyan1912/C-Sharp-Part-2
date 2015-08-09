using System;

class ParseURL
    {
        static void Main(string[] args)
        {
            // Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.

            Console.WriteLine("Enter a URL address: ");
            string url = Console.ReadLine();

            int protocolLength = url.IndexOf(':');
            string protocol = url.Substring(0, protocolLength);
            int serverLength = url.IndexOf('/', protocolLength + 3) - protocolLength - 3;
            string server = url.Substring(protocol.Length + 3, serverLength);
            int resourceLength = url.Length - serverLength - protocolLength - 3;
            string resource = url.Substring(serverLength + protocolLength + 3, resourceLength);
            Console.WriteLine("[protocol] = {0}\n[server] = {1}\n[resource] = {2}", protocol, server, resource);
        }
    }

