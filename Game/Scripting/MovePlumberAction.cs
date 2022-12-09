using Unit06.Game.Casting;

namespace Unit06.Game.Scripting
{
    public class MovePlumberAction : Action
    {
        public MovePlumberAction()
        {
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            foreach (Mario mario in cast.GetActors(Constants.PLUMBER_GROUP))
            {
                // Mario mario = (Mario)cast.GetFirstActor(Constants.PLUMBER_GROUP);
                Body body = mario.GetBody();
                Point position = body.GetPosition();
                Point velocity = body.GetVelocity();
                int x = position.GetX();
                int y = position.GetY();

                position = position.Add(velocity);
                if (x < 0)
                {
                    position = new Point(0, position.GetY());
                }
                else if (x > Constants.SCREEN_WIDTH - Constants.PLUMBER_WIDTH)
                {
                    position = new Point(Constants.SCREEN_WIDTH - Constants.PLUMBER_WIDTH,
                        position.GetY());
                }
                if (y < 0)
                {
                    position = new Point(position.GetX(), 0);
                }
                else if (y > Constants.SCREEN_HEIGHT - Constants.PLUMBER_HEIGHT)
                {
                    position = new Point(position.GetX(),
                        Constants.SCREEN_HEIGHT - Constants.PLUMBER_HEIGHT);
                }

                body.SetPosition(position);
            }
        }
    }
}