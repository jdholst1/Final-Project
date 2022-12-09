using System.Collections.Generic;
using Unit06.Game.Casting;
using Unit06.Game.Services;


namespace Unit06.Game.Scripting
{
    public class CollideBrickAction : Action
    {
        private AudioService _audioService;
        private PhysicsService _physicsService;

        public CollideBrickAction(PhysicsService physicsService, AudioService audioService)
        {
            this._physicsService = physicsService;
            this._audioService = audioService;
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            List<Actor> plumbers = cast.GetActors(Constants.PLUMBER_GROUP);
            foreach (Mario mario in plumbers)
            {
                // Mario mario = (Mario)cast.GetFirstActor(Constants.PLUMBER_GROUP);
                List<Actor> bricks = cast.GetActors(Constants.BRICK_GROUP);
                Stats stats = (Stats)cast.GetFirstActor(Constants.STATS_GROUP);

                foreach (Actor actor in bricks)
                {
                    Brick brick = (Brick)actor;
                    Body brickBody = brick.GetBody();
                    Body plumberBody = mario.GetBody();

                    if (_physicsService.HasCollided(brickBody, plumberBody))
                    {

                        int slope = 0;

                        while (_physicsService.HasCollided(brickBody, plumberBody) && slope < 40)
                        {
                            slope++;
                            mario.ShiftUp();
                        }
                        if (slope > 38)
                        {
                            mario.HitWall(slope);
                            mario.StopMoving(true, false);
                            mario.SetWall(true);
                        }
                        else
                        {
                            mario.StopMoving(false, true);
                            if (!(mario.GetBody().GetVelocity().GetY() > 0))
                            {
                                mario.SetGrounded(0);
                                mario.SetWall(false);
                            }

                        }
                        // int points = brick.GetPoints();
                        // stats.AddPoints(points);
                        // cast.RemoveActor(Constants.BRICK_GROUP, brick);
                    }
                }
            }
        }
    }
}