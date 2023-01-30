using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace physX;

public class Space {
    
    private List<PhysicalObject> physicalObjects;
    
    public Space() {
        physicalObjects = new List<PhysicalObject>();
    }
    
    public void SpawnObject(PhysicalObject obj) {
        physicalObjects.Add(obj);
    }

    public void Update(GameTime gameTime) {
        
    }

    public void Draw(SpriteBatch _spriteBatch) {

    }
}