import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";

@Injectable({
    providedIn: 'root'
})
export class DepositService {

    constructor(private http: HttpClient) { }

    depositMoney(userId: number, amount: number) {
        const req = { userId, amount };
        return this.http.post('https://localhost:44345/Deposit', req);
    }
}