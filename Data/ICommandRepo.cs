using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommandsService.Models;

namespace CommandsService.Data
{
    public interface ICommandRepo
    {
        bool SaveChanges();
        // Platforms
        IEnumerable<Platform> GetAllPlatforms();
        void CreatePlatform(Platform plat);
        bool PlatformExists(int platformId);
        bool ExternalPlatformExists(int externalPlatformId);

        // Commands
        IEnumerable<Command> GetCommandsFromPlatform(int platformId);
        Command GetCommand(int platformId, int commandId); 
        void CreateCommand(int platformId, Command command);

    }
}