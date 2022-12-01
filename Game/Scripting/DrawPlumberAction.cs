using Unit06.Game.Casting;
using Unit06.Game.Services;


namespace Unit06.Game.Scripting
{
    public class DrawPlumberAction : Action
    {
        private VideoService _videoService;

        public DrawPlumberAction(VideoService videoService)
        {
            this._videoService = videoService;
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            Mario mario = (Mario)cast.GetFirstActor(Constants.PLUMBER_GROUP);
            Body body = mario.GetBody();

            if (mario.IsDebug())
            {
                // mario.MoveNext();
                Rectangle rectangle = body.GetRectangle();
                Point size = rectangle.GetSize();
                Point pos = rectangle.GetPosition();
                _videoService.DrawRectangle(size, pos, Constants.PURPLE, false);
            }

            Animation animation = mario.GetAnimation();
            Image image = animation.NextImage();
            Point position = body.GetPosition();
            _videoService.DrawImage(image, position);
        }
    }
}