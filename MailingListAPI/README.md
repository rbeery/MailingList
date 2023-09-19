# Mailing List API

This project was developed with .Net core 7.0.  It provides endpoint/s for accessing the Mailing list.  Currently, the mailing list is a hard coded array within the app but would be replaced with a database to properly store the data in the future.

Additions to the application would be repositories and services to separate the database logic from the controller.


## Installation

This folder includes a solution that can be opened within Visual Studio or Rider.  From there the run configuration can be set up to run with IISExpress or with Mono on macOS

# Tests

Testing for this application has been set up within the same solution under Mailing List tests.

To run tests: 

Visual Studio:
Open the test explorer: choose Test on the Visual Studio menu, choose Windows, and then choose Test Explorer
Tests can be run individually are as a whole by selecting the Run All icon

Rider:
Select Unit tests from the left sidebar
From there click on the Run All Tests icon or the Run selected Tests icon based on what you are trying to test.  

In addition, use the top menu by selecting tests and then select which option you would like to run from there

These tests are very basic and test out a few different parameters for the get Mailing List endpoint

## Usage

Get Mailing List Endpoint: GET command with API path + "/MailingList"

When the project is run swagger will be accessible and the endpoint can be executed from there. 
