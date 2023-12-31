import { Component } from '@angular/core';
import { FormBuilder} from "@angular/forms";

@Component({
  selector: 'app-user-add',
  templateUrl: './user-add.component.html',
  styleUrls: ['./user-add.component.css']
})
export class UserAddComponent {
  // would need to add more form validation to ensure all values are filled out and a valid email address has been submitted
  mailingListForm = this.formBuilder.group({
    firstName: "",
    lastName: "",
    email: ""
  })
  // flag to mark when a value has been submitted.  In an actual application would wait for a response from the api call
  // once the response is received that information can be passed to the user
  submitted = false;

  //temporary array to store the submitted, not saved anywhere so will only persist within the current run, will be lost on reload
  mailList = Array();
  constructor(private formBuilder: FormBuilder) {}

  // function to toggle the submitted flag
  toggleSubmitted() {
    this.submitted = !this.submitted;
  }

  // function for submitting the data collected in the form
  onSubmit(): void {
    this.toggleSubmitted();
    // add code here to hit api through a service that is set up with api calls

    // code to push mailing list value to an array, will be lost when the app restarts
    //will be replaced by call to service which would add the item to the database
    this.mailList.push(this.mailingListForm.value);

    // console messages to ensure the data has been collected properly and added to the array
    console.warn('email address has been added: ', this.mailingListForm.value);
    console.warn('full mailing list: ', this.mailList);

    //resetting the form for addition uses
    this.mailingListForm.reset();
  }
}
