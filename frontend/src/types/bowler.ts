// Type for the bowler object
export type Bowler = {
    bowlerId: number;
    bowlerLastName: string;
    bowlerFirstName: string;
    bowlerMiddleInit: string;
    bowlerAddress: string;
    bowlerCity: string;
    bowlerState: string;
    bowlerZip: string;
    bowlerPhoneNumber: string;
    // Type for the team object
    teams: {
        teamId: number;
        teamName: string;
        captainId: number;
    }
}