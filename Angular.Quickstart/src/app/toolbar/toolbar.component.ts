
import { Component } from '@angular/core';

@Component({
    selector: 'toolbar',
    templateUrl: './toolbar.component.html'
})
export class ToolbarComponent {

    someText: string = "Click button below to see coolness";
    private count: number = 0;

    startTimer() {
        console.log("Starting timer");

        setInterval(() => {
            this.count++;
            this.someText = `The count is now ${this.count}`;
        }, 1000);)
    }
}
