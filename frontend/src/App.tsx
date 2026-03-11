import './App.css'
import BowlerList from './BowlerList'

// Function to display the header
// Header component
function Header() {
  return (
    <header className="header">
      <h1>Bowler List</h1>
      <p>Welcome to the Bowling League player directory, a centralized roster for the Marlins and Sharks teams. This application provides quick access to player contact details, including addresses and phone numbers, to help coordinate league activities and communication. Using this interactive interface, league members can easily view the current lineups and essential tournament information.</p>
    </header>
  );
}

// Main App component
function App() {


  return (
    <>
      <Header />
      <BowlerList />
    </>
  )
}

export default App
