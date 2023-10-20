using BasicOpenTK;
using OpenTK.Mathematics;

namespace GFXTest
{
    public class Rectengle : IDisposable
    {
        public VertexPositionColor[] Vertices { get; private set; } = new VertexPositionColor[4];
        public int[] Indices { get; private set; } = new int[6];



        public Rectengle(float width, float height, float x, float y, float r, float g, float b)
        {
            Vertices[0] = new VertexPositionColor(new Vector2(x, y + height), new Color4(r, g, b, 1f));
            Vertices[1] = new VertexPositionColor(new Vector2(x + width, y + height), new Color4(r, g, b, 1f));
            Vertices[2] = new VertexPositionColor(new Vector2(x + width, y), new Color4(r, g, b, 1f));
            Vertices[3] = new VertexPositionColor(new Vector2(x, y), new Color4(r, g, b, 1f));

            Indices[0] = 0;
            Indices[1] = 1;
            Indices[2] = 2;
            Indices[3] = 0;
            Indices[4] = 2;
            Indices[5] = 3;
        }


        ~Rectengle()
        {
            Dispose();
        }

        public void Dispose()
        { 
            GC.SuppressFinalize(this);
        }
    }
}
