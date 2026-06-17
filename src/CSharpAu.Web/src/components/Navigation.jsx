function Navigation({ currentPage, setCurrentPage }) {
  return (
    <nav className="bg-csharp-purple text-white shadow-lg">
      <div className="container mx-auto px-4 py-4">
        <div className="flex justify-between items-center">
          <div className="text-2xl font-bold">C# Australia</div>
          <ul className="flex space-x-6">
            <li><button onClick={() => setCurrentPage('home')} className="hover:text-gray-200">Home</button></li>
            <li><button onClick={() => setCurrentPage('services')} className="hover:text-gray-200">Services</button></li>
            <li><button onClick={() => setCurrentPage('clients')} className="hover:text-gray-200">Clients</button></li>
            <li><button onClick={() => setCurrentPage('team')} className="hover:text-gray-200">Team</button></li>
            <li><button onClick={() => setCurrentPage('contact')} className="hover:text-gray-200">Contact</button></li>
          </ul>
        </div>
      </div>
    </nav>
  );
}
export default Navigation;