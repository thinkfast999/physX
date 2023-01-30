using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace physX;

public class Vertex {
    private Vector2 Position { get; }
    private List<Vertex> Connections { get; }

    public Vertex(Vector2 _Position, List<Vertex>? _Connections) {
        Position = _Position;

        if (_Connections == null) {
            Connections = new List<Vertex>();
        } else {
            Connections = _Connections;
        }
    }

    public bool Connect(Vertex target) {
        if (Connections.Contains(target)) {
            return false;
        } else {
            Connections.Add(target);
            return true;
        }
    }

    public bool Disconnect(Vertex target) {
        if (Connections.Contains(target)) {
            Connections.Remove(target);
            return true;
        } else {
            return false;
        }
    }
}

public class VertexCursor {
    
    private Shape parent;
    private Vector2 position;
    private Vertex? originalVertex = null;
    private Vertex? lastVertex = null;

    public VertexCursor(Shape _parent) {
        
        parent = _parent;
        position = new Vector2(0, 0);

    }

    private void MoveCursor(Vector2 moveVector) {
        position += moveVector;
    }

    private void AddNextVertex() {
        var v = new Vertex(position, null);

        if (originalVertex == null) {
            originalVertex = v;
        }

        if (lastVertex != null) {
            lastVertex.Connect(v);
            v.Connect(lastVertex);
        }

        lastVertex = v;
    }

    public void ConnectToFirstVertex() {
        lastVertex.Connect(originalVertex);
    }

    public void AddVertexAtOffset(Vector2 offsetPosition) {
        MoveCursor(offsetPosition);
        AddNextVertex();
    }
}

public class Shape {
    private List<Vertex> Vertices { get; }
    private VertexCursor cursor;

    public Shape(List<Vertex>? _Vertices) {
        
        cursor = new VertexCursor(this);
        
        if (_Vertices == null) {
            Vertices = new List<Vertex>();
        } else {
            Vertices = _Vertices;
        }
    }
    
    public void PlaceVertices(Vector2[] vertexOffsets) {
        foreach(Vector2 v in vertexOffsets) {
            cursor.AddVertexAtOffset(v);
        }
        cursor.ConnectToFirstVertex();
    }

    public void Update(GameTime gameTime) {

    }

    public void Draw(BasicEffect _basicEffect) {

    }
}