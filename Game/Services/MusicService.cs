using Unit06.Game.Casting;


namespace Unit06.Game.Services
{
    public class MusicService
    {
        AudioService _audioservice;
        MusicService(AudioService audioservice)
        {
            this._audioservice = audioservice;
        }

    }
}