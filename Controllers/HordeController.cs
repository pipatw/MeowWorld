using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration; // 1st line added

namespace MeowWorld.Controllers
{
    
    public class HordeController : Controller
    {
        private static Dictionary<string, string> _Cats = new Dictionary<string, string>();

        [HttpPost("horde/{cat}")]
        public string Post(string cat, [FromBody]string sound)
        {
            _Cats[cat] = sound;

            return String.Format("{0} added to the horde!", cat);
        }

        [HttpGet("horde/{cat}")]
        public string Get(string cat)
        {
            if (!_Cats.ContainsKey(cat))
            {
                return "Cat not found.";
            }

            return _Cats[cat];
        }

        [HttpPatch("horde/{cat}")]
        public string Patch(string cat, [FromBody]string sound)
        {
            if (!_Cats.ContainsKey(cat))
            {
                return "Cat not found.";
            }

            _Cats[cat] = sound;

            return "Cat updated.";
        }

        [HttpDelete("horde/{cat}")]
        public string Delete(string cat)
        {
            if (!_Cats.ContainsKey(cat))
            {
                return "Cat not found.";
            }

            _Cats.Remove(cat);

            return "Cat deleted.";
        }
    }

}