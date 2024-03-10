using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using AutoMapper;
using CommandsService.Dtos;

namespace CommandsService.EventProcessing
{
    public class EventProcessor : IEventProcessor
    {
        private readonly IServiceScopeFactory _scopeFactory;
        private readonly IMapper _mapper;

        public EventProcessor(IServiceScopeFactory scopeFactory, IMapper mapper)
        {
            _scopeFactory = scopeFactory;
            _mapper = mapper;
        }
        public void ProcessEvent(string message)
        {
            throw new NotImplementedException();
        }

        private EventType DetermineEvent(string notificationMessage)
        {
            Console.WriteLine("--> Determining Event");
            var eventType = JsonSerializer.Deserialize<GenericEventDto>(notificationMessage);

            switch(eventType.Event)
            {
                case "Platform_Published":
                    Console.WriteLine("Platform Publish Event Detected");
                    return EventType.PlatformPublished;
                default:
                    Console.WriteLine("--> Could not Determent Event Type");
                    return EventType.Undetermined;
            }
        }
    }

    enum EventType
    {
        PlatformPublished,
        Undetermined
    }
}