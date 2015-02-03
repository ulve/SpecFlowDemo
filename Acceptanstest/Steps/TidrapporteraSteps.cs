using Acceptanstest.Pages;
using NUnit.Framework;
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
        [Given(@"att jag befinner mig på inmatningssidan")]
        public void GivetAttJagBefinnerMigPaInmatningssidan()
        {
            Inmatningssida.GåTill();
        }

        [Given(@"jag har fyllt i tiden (.*) timmar")]
        public void GivetJagHarFylltITidenTimmar(string tid)
        {
            Inmatningssida.FyllTid(tid);
        }

        [Given(@"jag har fyllt i kunden (.*)")]
        public void GivetJagHarFylltIKunden(string kund)
        {
            Inmatningssida.FyllKund(kund);
        }

        [Given(@"jag har fyllt följande värden (.*), (.*) och (.*)")]
        public void GivetJagHarFylltFoljandeVarden(string tid, string kund, string kommentar)
        {
            Inmatningssida.FyllTid(tid);
            Inmatningssida.FyllKund(kund);
            Inmatningssida.FyllKommentar(kommentar);
        }

        [When(@"jag trycker på lägg till")]
        public void NarJagTryckerPaLaggTill()
        {
            Inmatningssida.TryckLäggTill();
        }

        [Then(@"skall en ny post för (.*) läggas till")]
        public void SaSkallEnNyPostForGullans_TalsmoblerLaggasTill(string post)
        {
            StringAssert.Contains(post, Översikt.Html);
        }

        [Then(@"skall jag få (.*)")]
        public void SaSkallJagFa(string meddelande)
        {
            StringAssert.Contains(meddelande, Inmatningssida.Html);            
        }

    }
}
