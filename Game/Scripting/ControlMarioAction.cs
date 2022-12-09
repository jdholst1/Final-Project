using Unit06.Game.Casting;
using Unit06.Game.Services;
using System.Collections.Generic;

namespace Unit06.Game.Scripting
{
    public class ControlPlumberAction : Action
    {
        private KeyboardService _keyboardService;
        private AudioService _audioService;

        public ControlPlumberAction(KeyboardService keyboardService, AudioService audioservice)
        {
            this._keyboardService = keyboardService;
            this._audioService = audioservice;
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            int side = 1;
            // List<Mario> plumbers = (Mario)cast.GetActors(Constants.PLUMBER_GROUP);
            Mario mario = (Mario)cast.GetFirstActor(Constants.PLUMBER_GROUP);
            Mario luigi = (Mario)cast.GetActors(Constants.PLUMBER_GROUP)[1];
            if (_keyboardService.IsKeyDown(Constants.LEFT))
            {
                mario.MoveLeft();
            }
            else if (_keyboardService.IsKeyDown(Constants.RIGHT))
            {
                mario.MoveRight();
                side = -1;
            }
            if (_keyboardService.IsKeyDown(Constants.UP) && (mario.GetGrounded() < 4))
            {
                mario.Bounce();
                Sound sound = new Sound(Constants.BOUNCE_SOUND);
                _audioService.PlaySound(sound);
            }
            else if (_keyboardService.IsKeyDown(Constants.UP) && (mario.GetWall()))
            {
                mario.WallKick(side);
            }
            mario.StopMoving(false, false);
            mario.Fall();
            mario.ReduceIdle();

            if (_keyboardService.IsKeyDown(Constants.DOWN))
            {
                mario.Duck();
            }

            //Luigi
            if (_keyboardService.IsKeyDown(Constants.LEFT2))
            {
                luigi.MoveLeft();
            }
            else if (_keyboardService.IsKeyDown(Constants.RIGHT2))
            {
                luigi.MoveRight();
                side = -1;
            }
            if (_keyboardService.IsKeyDown(Constants.UP2) && (luigi.GetGrounded() < 4))
            {
                luigi.Bounce();
                Sound sound = new Sound(Constants.BOUNCE_SOUND);
                _audioService.PlaySound(sound);
            }
            else if (_keyboardService.IsKeyDown(Constants.UP2) && (luigi.GetWall()))
            {
                luigi.WallKick(side);
            }
            luigi.StopMoving(false, false);
            luigi.Fall();
            luigi.ReduceIdle();

            if (_keyboardService.IsKeyDown(Constants.DOWN2))
            {
                luigi.Duck();
            }


        }
    }
}