using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VRC.Core;

namespace ChromaticaAPI.ApplicationBot
{
    static class RoomExtensions
    {
        public static ApiWorld Current_World { get { return RoomManager.field_Internal_Static_ApiWorld_0; } }
        public static string Current_World_ID { get { return $"{Current_World.id}:{Current_World.currentInstanceIdWithTags}"; } }
        public static bool In_World { get { return Current_World != null; } }
    }
}
