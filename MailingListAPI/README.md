# Mailing List API

This project was developed with .Net core 7.0.  It provides endpoint/s for accessing the Mailing list.  Currently the mailing list is a hard coded array within the app but in the future would be replaced with a database to properly store the data.

Additions to the application would be repositores and servies to seperate out the database logic from the controller.


## Installation

This folder includes a solution which can be opened within Visual Studio or Rider.  From there the run configuration can be set up to run with IISExpress or with Mono on MacOs

# Tests

Testing for this application has been setup within the same solution under Mailing List tests.

These tests are very basic and test out a few different parameters for the get Mailing List endpoint

## Usage

Get Mailing List Endpoint: GET command with api path + "/MailingList"

When the project is run swagger will be accessible and the endpoint can be executed from there. 
