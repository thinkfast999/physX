using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace physX;

public class PhysicalObject {
    
    private string uid;
    private Vector2 Position { get; }
    private Vector2 Velocity { get; }
    private Vector2 Acceleration { get; }
    private float Mass { get; }

    public PhysicalObject(Vector2 _Position, Vector2 _Velocity, Vector2 _Acceleration, float _Mass) {
        uid = Globals.randomUID(8);
        Position = _Position;
        Velocity = _Velocity;
        Acceleration = _Acceleration;
        Mass = _Mass;
    }

    public void Update(GameTime gameTime) {

    }

    public void Draw(SpriteBatch _spriteBatch) {

    }
}