using PopTarts.Recepies;
using System;
using TechTalk.SpecFlow;

namespace PopTarts.specs.Steps
{
    [Binding]
    public class MesureCalcSteps
    {
        [Given(@"that I need an American cup")]
        public void GivenThatINeedAnAmericanCup()
        {
            
        }
        
        [Given(@"the decimals are rounded to (.*)")]
        public void GivenTheDecimalsAreRoundedTo(decimal p0)
        {
             Check.IsDecimal(p0);
        }
        
        [When(@"the amount of cups is (.*)")]
        public void WhenTheAmountOfCupsIs(int p0)
        {
            
        }
        
        [Then(@"the Swedish amount is (.*) dl")]
        public void ThenTheSwedishAmountIsDl(decimal cup)
        {
            Convertion.ConvertToDL(cup);
        }
    }
}
