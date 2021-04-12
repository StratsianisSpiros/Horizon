using Entities.Models;
using System;
using System.Collections.Generic;

namespace Repositories.Data
{
    public class RequestData
    {
        private readonly List<Request> Requests = new List<Request>()
        {
            new Request { RequestId = 1, Username = "Steinbeck", RequestDate = new DateTime(2021, 02, 13), Content = "I need vacation from 18/04 to 30/04", Response = "Your request has been accepted!", AskRequest = true},
            new Request { RequestId = 2, Username = "Steinbeck", RequestDate = new DateTime(2021, 02, 15), Content = "I have a medical appointment tomorrow. I need day off", Response = "Please inform erlier next time.", AskRequest = true},
            new Request { RequestId = 3, Username = "Steinbeck", RequestDate = new DateTime(2021, 02, 20), Content = "I need support for the next project", Response = "Sorry, no other people available", AskRequest = false},
            new Request { RequestId = 4, Username = "Orwell", RequestDate = new DateTime(2021, 01, 15), Content = "I need more details about this project", Response = "Contact me tomorrow morning", AskRequest = true},
            new Request { RequestId = 5, Username = "Orwell", RequestDate = new DateTime(2021, 01, 20), Content = "Need more holiday", Response = "Can't give you at the moment", AskRequest = false},
            new Request { RequestId = 6, Username = "Orwell", RequestDate = new DateTime(2021, 02, 19), Content = "I have to go to the doctor", Response = "Just take some aspirin", AskRequest = false},
            new Request { RequestId = 7, Username = "Hemingway", RequestDate = new DateTime(2020, 12, 12), Content = "I need some overtime", Response = "No extra work at the moment", AskRequest = false},
            new Request { RequestId = 8, Username = "Hemingway", RequestDate = new DateTime(2021, 02, 14), Content = "I need vacation from 18/03 to 25/03", Response = "Your request has been accepted!", AskRequest = true},
            new Request { RequestId = 9, Username = "Hemingway", RequestDate = new DateTime(2021, 03, 27), Content = "I need to upgrade my equipment", Response = "You will get some available money for your upgrades", AskRequest = true},
            new Request { RequestId = 10, Username = "Plath", RequestDate = new DateTime(2021, 01, 01), Content = "I would like some days off", Response = "Your request will be considered", AskRequest = true},
            new Request { RequestId = 11, Username = "Plath", RequestDate = new DateTime(2021, 02, 23), Content = "I need a new typewriter", Response = "Can't afford a new one this year", AskRequest = false},
            new Request { RequestId = 12, Username = "Plath", RequestDate = new DateTime(2021, 02, 25), Content = "I need vacation from 20/03 to 30/03", Response = "I'm sorry you can't have holidays this week", AskRequest = false},
            new Request { RequestId = 13, Username = "Beauvoir", RequestDate = new DateTime(2021, 01, 10), Content = "I want extra time to finish my work", Response = "We can give you two extra days", AskRequest = true},
            new Request { RequestId = 14, Username = "Beauvoir", RequestDate = new DateTime(2021, 01, 11), Content = "Please help me finish my work", Response = "Request accepted", AskRequest = true},
            new Request { RequestId = 15, Username = "Beauvoir", RequestDate = new DateTime(2021, 01, 17), Content = "I need a new computer", Response = "To expensive to get one", AskRequest = false},
        };

        internal static List<Request> GetData() => new RequestData().Requests;
    }
}
