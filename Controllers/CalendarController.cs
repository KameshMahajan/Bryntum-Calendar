using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace Bryntum_Calendar.Controllers
{
    public class CalendarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult GetEvents()
        {
            var result = new
            {
                success = true,
                events = new
                {
                    rows = new[]
                    {
                        new {
                            id = 1,
                            name = "kamesh Meeting",
                            startDate = "2025-06-04T10:00:00",
                            endDate = "2025-06-04T12:00:00",
                            resourceId=2,
                            cls= ""
                        },
                        new {
                            id = 2,
                            name = "Test Meeting 2",
                            startDate = "2025-06-07T10:00:00",
                            endDate = "2025-06-07T11:00:00",
                            resourceId=1,
                            cls= ""
                        },
                        new {
                            id = 3,
                            name = "Meeting 3",
                            startDate = "2025-06-01T10:00:00",
                            endDate = "2025-06-01T13:00:00",
                            resourceId=2,
                            cls= ""
                        },
                        new {
                            id = 4,
                            name = "Meeting 4",
                            startDate = "2025-06-15T10:00:00",
                            endDate = "2025-06-15T11:00:00",
                            resourceId=3,
                            cls= ""
                        },
                        new {
                            id = 5,
                            name = "Meeting 5",
                            startDate = "2025-06-18T10:00:00",
                            endDate = "2025-06-18T11:00:00",
                            resourceId=3,
                            cls= "break-event"
                        },
                        new {
                            id= 100,
                            name= "Time Block",
                            startDate= "2025-06-10T15:15:00",
                            endDate= "2025-06-10T15:45:00",
                            resourceId= 1,
                            cls= "break-event"
                        }
    }
                },
                resources = new
                {
                    rows = new[]
                    {
                        new {
                            id = 1,
                            name = "Jone",
                            eventColor ="yellow"
                        },
                         new {
                            id = 2,
                            name = "Bryan",
                            eventColor ="red"
                        }, 
                        new {
                            id = 3,
                            name = "Lauren",
                            eventColor ="violet"
                        }
                    }
                }
            };

            return Json(result);
        }

        [HttpPost]
        public IActionResult SaveEvents([FromBody] JsonElement payload)
        {
            // Handle create/update/delete here
            return Json(new { success = true });
        }
    }
}
