export class Task {
    constructor() {
        this.name = '';
        this.date = new Date();
        this.state = false;
        this.description = '';
    }
    
    name: string;
    date: Date;
    state: boolean;
    description: string;
}
