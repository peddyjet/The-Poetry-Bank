
namespace The_Poetry_Bank
	{
    public struct Poem
    {
        public readonly string name;
        public readonly string description;
        public readonly string fullPoem;

        public Poem(string name, string description, string fullPoem) => (this.name, this.description, this.fullPoem) = (name, description, fullPoem);

        public override string ToString() => name;
        
    }

	}