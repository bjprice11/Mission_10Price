import {useState, useEffect} from 'react'
import type {Bowler} from './types/bowler'

// Function to display the bowler list
function BowlerList() {
    // State to store the bowler list, initially empty
        const [bowlers, setBowlers] = useState<Bowler[]>([])

        // Call the API to get the bowler list
        useEffect(() => {
            //async means the function can be paused and resumed later
            //await means the function will wait for the fetch to complete before continuing
            const fetchBowlers = async () => {
                const response = await fetch('https://localhost:5000/api/Bowling')
                //fills our data with the response from the API
                const data = await response.json()
                setBowlers(data) //set the state with the data
            };
            fetchBowlers() //call the function
        }, []) //empty dependency array means the function will only run once when the component mounts
        return (
            <>
            <table className="table">
                <thead className="table-header">
                    <tr>
                        <th>Bowler Name</th>
                        <th>Team</th>
                        <th>Address</th>
                        <th>City</th>
                        <th>State</th>
                        <th>Zip</th>
                        <th>Phone Number</th>
                    </tr>
                </thead>
                <tbody>
                    {bowlers.map((bowler) => ( //map the bowler list to the table
                        <tr key={bowler.bowlerId}>
                            <td>{bowler.bowlerFirstName} {bowler.bowlerLastName}</td> //display the bowler name
                            <td>{bowler.teams?.teamName}</td>
                            <td>{bowler.bowlerAddress}</td>
                            <td>{bowler.bowlerCity}</td>
                            <td>{bowler.bowlerState}</td>
                            <td>{bowler.bowlerZip}</td>
                            <td>{bowler.bowlerPhoneNumber}</td>
                            
                        </tr>
                    ))}
                </tbody>
            </table>
            </>
        )
    }
    export default BowlerList