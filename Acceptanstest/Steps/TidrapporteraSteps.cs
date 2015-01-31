using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Acceptanstest.Steps
{
    [Binding]
    public class TidrapporteraSteps
    {
        [Given(@"jag har fyllt i tiden (.*) timmar")]
        public void GivetJagHarFylltITidenTimmar(string tid)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"jag har fyllt i kunden (.*)")]
        public void GivetJagHarFylltIKundenNissesKottOchTV(string kund)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"jag trycker på lägg till")]
        public void NarJagTryckerPaLaggTill()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"skall en ny post läggast till")]
        public void SaSkallEnNyPostLaggastTill()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"jag har fyllt följande värden (.*), (.*) och (.*)")]
        public void GivetJagHarFylltFoljandeVardenNissesKottOchTVJagVetInteHurLangeJagJobbat(string tid, string kund, string kommentar)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"skall jag få (.*)")]
        public void SaSkallJagFaTidSaknas(string meddelande)
        {
            ScenarioContext.Current.Pending();
        }

    }
}
