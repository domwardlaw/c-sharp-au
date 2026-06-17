function Footer() {
  return (
    <footer className="bg-gray-800 text-white py-8 mt-12">
      <div className="container mx-auto px-4">
        <div className="grid grid-cols-3 gap-8 mb-8">
          <div>
            <h3 className="font-bold text-lg mb-4">C# Australia</h3>
            <p>Enterprise software development and consulting services</p>
          </div>
          <div>
            <h3 className="font-bold text-lg mb-4">Quick Links</h3>
            <ul className="space-y-2">
              <li><a href="#" className="hover:text-csharp-blue">Services</a></li>
              <li><a href="#" className="hover:text-csharp-blue">Clients</a></li>
              <li><a href="#" className="hover:text-csharp-blue">Team</a></li>
            </ul>
          </div>
          <div>
            <h3 className="font-bold text-lg mb-4">Contact</h3>
            <p>Email: info@c-sharp.au</p>
            <p>Phone: +61 2 1234 5678</p>
          </div>
        </div>
        <div className="border-t border-gray-700 pt-8 text-center">
          <p>Copyright © 2024 C# Australia. All rights reserved.</p>
        </div>
      </div>
    </footer>
  );
}
export default Footer;