using Microsoft.AspNetCore.Mvc;

namespace WFD.API.Controllers
{
    [ApiController]
    [Route("Tests")]
    public class TestControlercs : ControllerBase
    {
        Uczelnia x;
        Człowiek y;
        public TestControlercs(Uczelnia u, Człowiek c)
        {
            x = u;
            y = c;
        }

        [HttpGet("PodajKody")]
        public string PodajKody()
        {
            string text = "";

            text += "Uczelnia: " + x.GetHashCode();
            text += "/n Człowiek: " + y.GetHashCode();

            return text;
        }
    }
}
