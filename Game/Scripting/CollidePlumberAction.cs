using Unit06.Game.Casting;
using Unit06.Game.Services;


namespace Unit06.Game.Scripting
{
    public class CollidePlumberAction : Action
    {
        private AudioService _audioService;
        private PhysicsService _physicsService;

        public CollidePlumberAction(PhysicsService physicsService, AudioService audioService)
        {
            this._physicsService = physicsService;
            this._audioService = audioService;
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            //Ball ball = (Ball)cast.GetFirstActor(Constants.BALL_GROUP);
            Mario mario = (Mario)cast.GetFirstActor(Constants.PLUMBER_GROUP);
            //Body ballBody = ball.GetBody();
            Body plumberBody = mario.GetBody();

            // if (_physicsService.HasCollided(racketBody, ballBody))
            // {
            //     ball.BounceY();
            //     Sound sound = new Sound(Constants.BOUNCE_SOUND);
            //     _audioService.PlaySound(sound);
            // }
        }
    }
}