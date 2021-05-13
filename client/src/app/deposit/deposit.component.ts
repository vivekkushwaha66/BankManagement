import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { DepositService } from './deposit.service';

@Component({
  selector: 'app-deposit',
  templateUrl: './deposit.component.html',
  styleUrls: ['./deposit.component.scss']
})
export class DepositComponent implements OnInit {
  depositForm: FormGroup;
  isLoading: boolean = false;

  constructor(private fb: FormBuilder,
    private depositService: DepositService) { }

  ngOnInit(): void {
    this.createForm();
  }


  createForm() {
    this.depositForm = this.fb.group({
      userId: new FormControl('', [Validators.required]),
      amount: new FormControl(0, [Validators.required, Validators.min(1)])
    });
  }

  submitForm() {
    if (this.depositForm.valid) {
      this.isLoading = true;
      const { userId, amount } = this.depositForm.value;
      this.depositService.depositMoney(userId, amount)
        .subscribe(data => {
          this.isLoading = false;
          console.log('Money Deposited');
          this.depositForm.reset();
        });
    }
  }
}
