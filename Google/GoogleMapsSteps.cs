using Google.GoogleMaps;
using System;
using TechTalk.SpecFlow;

namespace Google
{
    [Binding]
    public class GoogleMapsSteps
    {
        Homepage hp = new Homepage();
        [Given(@"Iam At Google Maps Home Page")]
        public void GivenIamAtGoogleMapsHomePage()
        {
            hp.IamatGoogleMapsHomePage();
        }
        
        [Given(@"I Search Banglore")]
        public void GivenISearchBanglore()
        {
            hp.SearchBanglore();
        }
        
        [Given(@"I Click on Directions")]
        public void GivenIClickOnDirections()
        {
            hp.ClickDirections();
        }
        
        [Given(@"Get Directions from Hyderabad to Banglore")]
        public void GivenGetDirectionsFromHyderabadToBanglore()
        {
            hp.GetDirections();
        }
        
        [Given(@"Check Zoom Levels")]
        public void GivenCheckZoomLevels()
        {
            hp.CheckZoomlevels();
        }
        
        [Given(@"Get Route Options for Public Transport,walk")]
        public void GivenGetRouteOptionsForPublicTransportWalk()
        {
            hp.CheckRoutesForPublicTransportAndWalk();
        }
        
        [Given(@"I check Context menu")]
        public void GivenICheckContextMenu()
        {
            hp.CheckContextMenu();
        }
        
        [Given(@"I am at Google Maps Homepage")]
        public void GivenIAmAtGoogleMapsHomepage()
        {
            hp.IamatGoogleMapsHomePage();
        }
        
        [Given(@"I check Menu")]
        public void GivenICheckMenu()
        {
            hp.ClickMenu();
        }
        
        [Given(@"i click your places")]
        public void GivenIClickYourPlaces()
        {
            hp.Clickyourplaces();
        }
        
        [Given(@"I Enter Username and Password")]
        public void GivenIEnterUsernameAndPassword()
        {
            hp.EnterUserNameandPassword();
        }
        
        [Given(@"I Click saved")]
        public void GivenIClickSaved()
        {
            hp.ClickSaved();
        }
        
        [Given(@"I Click edit list in Favorites")]
        public void GivenIClickEditListInFavorites()
        {
            hp.ClickFavorites();
        }
        
        [Given(@"I  Click Add Place")]
        public void GivenIClickAddPlace()
        {
            hp.ClickAddPlace();
        }
        
        [Given(@"I Enter place name")]
        public void GivenIEnterPlaceName()
        {
            hp.EnterPlaceName();
        }
        
        [When(@"Save and Share location")]
        public void WhenSaveAndShareLocation()
        {
            hp.ClickSaveAndShare();
        }
        
        [When(@"I select From DropDown")]
        public void WhenISelectFromDropDown()
        {
            hp.SelectFromDropDown();
        }
        
        [Then(@"It is Asking Options Fb or Twitter")]
        public void ThenItIsAskingOptionsFbOrTwitter()
        {
            hp.checkResult();
        }
        
        [Then(@"place is added to Favorites")]
        public void ThenPlaceIsAddedToFavorites()
        {
            hp.CheckifPlaceisAddedorNot();
        }
    }
}
