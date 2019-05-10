Feature: GoogleMaps
	

@mytag
Scenario:Google Maps
	Given Iam At Google Maps Home Page
	And I Search Banglore
	And I Click on Directions
	And Get Directions from Hyderabad to Banglore
	And Check Zoom Levels
	And Get Route Options for Public Transport,walk
	And I check Context menu
	When Save and Share location
	Then It is Asking Options Fb or Twitter
@mytag
Scenario: Add to Favorites
Given I am at Google Maps Homepage
And I check Menu
And i click your places
And I Enter Username and Password
And I Click saved
And I Click edit list in Favorites
And I  Click Add Place
And I Enter place name
When I select From DropDown
Then place is added to Favorites



