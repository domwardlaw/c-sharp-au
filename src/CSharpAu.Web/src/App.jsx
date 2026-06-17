import { useState } from 'react';
import Navigation from './components/Navigation';
import Footer from './components/Footer';
import Home from './pages/Home';

function App() {
  const [currentPage, setCurrentPage] = useState('home');
  return (
    <div className="flex flex-col min-h-screen">
      <Navigation currentPage={currentPage} setCurrentPage={setCurrentPage} />
      <main className="flex-grow">
        {currentPage === 'home' && <Home />}
      </main>
      <Footer />
    </div>
  );
}
export default App;