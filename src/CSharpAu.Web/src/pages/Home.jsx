function Home() {
  return (
    <div>
      <section className="bg-csharp-purple text-white py-20">
        <div className="container mx-auto px-4 text-center">
          <h1 className="text-5xl font-bold mb-4">C# Australia</h1>
          <p className="text-xl mb-8">Enterprise Software Development & Consulting</p>
          <button className="bg-csharp-blue hover:bg-blue-700 text-white font-bold py-2 px-6 rounded">Get Started</button>
        </div>
      </section>
      <section className="py-16">
        <div className="container mx-auto px-4">
          <h2 className="text-4xl font-bold mb-8 text-center">About Us</h2>
          <p className="text-lg text-gray-700 max-w-2xl mx-auto text-center">C# Australia is a leading software development company specializing in enterprise solutions, cloud technologies, and digital transformation.</p>
        </div>
      </section>
      <section className="bg-gray-100 py-16">
        <div className="container mx-auto px-4">
          <h2 className="text-4xl font-bold mb-12 text-center">Our Services</h2>
          <div className="grid grid-cols-3 gap-8">
            <div className="bg-white p-6 rounded shadow">
              <h3 className="text-xl font-bold mb-4">Languages</h3>
              <p>C#, Java, JavaScript, SQL, Oracle expertise</p>
            </div>
            <div className="bg-white p-6 rounded shadow">
              <h3 className="text-xl font-bold mb-4">Cloud Solutions</h3>
              <p>Azure, AWS, GCP infrastructure</p>
            </div>
            <div className="bg-white p-6 rounded shadow">
              <h3 className="text-xl font-bold mb-4">Enterprise Apps</h3>
              <p>SaaS, Web Services, Desktop Applications</p>
            </div>
          </div>
        </div>
      </section>
    </div>
  );
}
export default Home;