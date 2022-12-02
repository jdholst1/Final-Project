using Unit06.Game.Casting;
using Unit06.Game.Services;


namespace Unit06.Game.Scripting
{
    public class ControlPlumberAction : Action
    {
        private KeyboardService _keyboardService;

        public ControlPlumberAction(KeyboardService keyboardService)
        {
            this._keyboardService = keyboardService;
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            Mario mario = (Mario)cast.GetFirstActor(Constants.PLUMBER_GROUP);
            if (_keyboardService.IsKeyDown(Constants.LEFT))
            {
                mario.MoveLeft();
            }
            else if (_keyboardService.IsKeyDown(Constants.RIGHT))
            {
                mario.MoveRight();
            }
            if (_keyboardService.IsKeyDown(Constants.UP))
            {
                mario.Bounce();
            }
            else if (_keyboardService.IsKeyDown(Constants.DOWN))
            {
                mario.Duck();
            }
            mario.StopMoving(false, false);


        }
    }
}