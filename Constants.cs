using System.Collections.Generic;
using Unit06.Game.Casting;


namespace Unit06
{
    public class Constants
    {
        // ----------------------------------------------------------------------------------------- 
        // GENERAL GAME CONSTANTS
        // ----------------------------------------------------------------------------------------- 

        // GAME
        public static string GAME_NAME = "Soup R Mario Lost in the Bitlands";
        public static int FRAME_RATE = 60;

        // SCREEN
        public static int SCREEN_WIDTH = 1040;
        public static int SCREEN_HEIGHT = 680;
        public static int CENTER_X = SCREEN_WIDTH / 2;
        public static int CENTER_Y = SCREEN_HEIGHT / 2;

        // FIELD
        public static int FIELD_TOP = 60;
        public static int FIELD_BOTTOM = SCREEN_HEIGHT;
        public static int FIELD_LEFT = 0;
        public static int FIELD_RIGHT = SCREEN_WIDTH;

        // FONT
        public static string FONT_FILE = "Assets/Fonts/zorque.otf";
        public static int FONT_SIZE = 32;

        // SOUND
        public static string BOUNCE_SOUND = "Assets/Sounds/smw_jump.wav";
        public static string WELCOME_SOUND = "Assets/Sounds/start.wav";
        public static string OVER_SOUND = "Assets/Sounds/over.wav";
        public static string WALLKICK_SOUND = "Assets/Sounds/smw_stomp_no_damage.wav";

        //MUSIC
        public static string MUSIC_TRACK_1 = "Assets/Sounds/16 Athletic.mp3";

        // TEXT
        public static int ALIGN_LEFT = 0;
        public static int ALIGN_CENTER = 1;
        public static int ALIGN_RIGHT = 2;


        // COLORS
        public static Color BLACK = new Color(0, 0, 0);
        public static Color WHITE = new Color(255, 255, 255);
        public static Color PURPLE = new Color(255, 0, 255);
        public static Color BLUE = new Color(100, 150, 225);

        // KEYS
        public static string LEFT = "left";
        public static string RIGHT = "right";
        public static string UP = "up";
        public static string DOWN = "down";
        public static string LEFT2 = "a";
        public static string RIGHT2 = "d";
        public static string UP2 = "w";
        public static string DOWN2 = "s";
        public static string SPACE = "space";
        public static string ENTER = "enter";
        public static string PAUSE = "p";
        public static string OZ = "o";


        // SCENES
        public static string NEW_GAME = "new_game";
        public static string TRY_AGAIN = "try_again";
        public static string NEXT_LEVEL = "next_level";
        public static string IN_PLAY = "in_play";
        public static string GAME_OVER = "game_over";

        // LEVELS
        public static string LEVEL_FILE = "Assets/Data/level-{0:000}.txt";
        public static int BASE_LEVELS = 5;

        // ----------------------------------------------------------------------------------------- 
        // SCRIPTING CONSTANTS
        // ----------------------------------------------------------------------------------------- 

        // PHASES
        public static string INITIALIZE = "initialize";
        public static string LOAD = "load";
        public static string INPUT = "input";
        public static string UPDATE = "update";
        public static string OUTPUT = "output";
        public static string UNLOAD = "unload";
        public static string RELEASE = "release";

        // ----------------------------------------------------------------------------------------- 
        // CASTING CONSTANTS
        // ----------------------------------------------------------------------------------------- 

        // STATS
        public static string STATS_GROUP = "stats";
        public static int DEFAULT_LIVES = 30;
        public static int MAXIMUM_LIVES = 5;

        // HUD
        public static int HUD_MARGIN = 15;
        public static string LEVEL_GROUP = "level";
        public static string LIVES_GROUP = "lives";
        public static string SCORE_GROUP = "score";
        public static string LEVEL_FORMAT = "LEVEL: {0}";
        public static string LIVES_FORMAT = "LIVES: {0}";
        public static string SCORE_FORMAT = "SCORE: {0}{1}";

        // // BALL
        // public static string BALL_GROUP = "balls";
        // public static string BALL_IMAGE = "Assets/Images/000.png";
        // public static int BALL_WIDTH = 28;
        // public static int BALL_HEIGHT = 28;
        // public static int BALL_VELOCITY = 6;

        // MARIO
        public static string PLUMBER_GROUP = "plumbers";

        public static List<string> MARIO_IDLE
            = new List<string>() {
                "Assets/Images/mini_mario01.png"
            };

        public static List<string> MARIO_WALK
            = new List<string>() {
                "Assets/Images/mini_mario01.png",
                "Assets/Images/mini_mario02.png"
            };

        public static List<string> MARIO_JUMP
            = new List<string>() {
                "Assets/Images/mini_mario03.png"
            };

        public static List<string> MARIO_FALL
            = new List<string>() {
                "Assets/Images/mini_mario04.png"
            };

        public static List<string> MARIO_DUCK
            = new List<string>() {
                "Assets/Images/mini_mario05.png"
            };
        public static List<string> MARIO_IDLE_L
            = new List<string>() {
                "Assets/Images/mini_mario07.png"
            };

        public static List<string> MARIO_WALK_L
            = new List<string>() {
                "Assets/Images/mini_mario07.png",
                "Assets/Images/mini_mario09.png"
            };

        public static List<string> MARIO_JUMP_L
            = new List<string>() {
                "Assets/Images/mini_mario10.png"
            };

        public static List<string> MARIO_FALL_L
            = new List<string>() {
                "Assets/Images/mini_mario11.png"
            };

        public static List<string> MARIO_DUCK_L
            = new List<string>() {
                "Assets/Images/mini_mario12.png"
            };

        public static List<string> MARIO_SPIN
            = new List<string>() {
                "Assets/Images/mini_mario01.png",
                "Assets/Images/mini_mario06.png",
                "Assets/Images/mini_mario07.png",
                "Assets/Images/mini_mario08.png"
            };
        public static List<string> LUIGI_IDLE
            = new List<string>() {
                "Assets/Images/Weegee01.png"
            };

        public static List<string> LUIGI_WALK
            = new List<string>() {
                "Assets/Images/Weegee01.png",
                "Assets/Images/Weegee02.png"
            };

        public static List<string> LUIGI_JUMP
            = new List<string>() {
                "Assets/Images/Weegee03.png"
            };

        public static List<string> LUIGI_FALL
            = new List<string>() {
                "Assets/Images/Weegee04.png"
            };

        public static List<string> LUIGI_DUCK
            = new List<string>() {
                "Assets/Images/Weegee05.png"
            };
        public static List<string> LUIGI_IDLE_L
            = new List<string>() {
                "Assets/Images/Weegee07.png"
            };

        public static List<string> LUIGI_WALK_L
            = new List<string>() {
                "Assets/Images/Weegee07.png",
                "Assets/Images/Weegee09.png"
            };

        public static List<string> LUIGI_JUMP_L
            = new List<string>() {
                "Assets/Images/Weegee10.png"
            };

        public static List<string> LUIGI_FALL_L
            = new List<string>() {
                "Assets/Images/Weegee11.png"
            };

        public static List<string> LUIGI_DUCK_L
            = new List<string>() {
                "Assets/Images/Weegee12.png"
            };

        public static List<string> LUIGI_SPIN
            = new List<string>() {
                "Assets/Images/Weegee01.png",
                "Assets/Images/mini_Weegee06.png",
                "Assets/Images/mini_Weegee07.png",
                "Assets/Images/mini_Weegee08.png"
            };


        public static int PLUMBER_WIDTH = 32;
        public static int PLUMBER_HEIGHT = 50;
        public static int PLUMBER_RATE = 4;
        public static int PLUMBER_SPEED = 10;
        public static int PLUMBER_JUMP = 5;

        // BRICK
        public static string BRICK_GROUP = "bricks";


        public static Dictionary<string, List<string>> BRICK_IMAGES
            = new Dictionary<string, List<string>>() {
                //null space, Void
                { "v", new List<string>() {
                    "Assets/Images/block50.png"
                    }
                },
                //Ground
                { "g", new List<string>() {
                    "Assets/Images/block31.png"
                    }
                },
                //? Blocks
                { "b", new List<string>() {
                    "Assets/Images/block15.00.png",
                    "Assets/Images/block15.01.png",
                    "Assets/Images/block15.02.png",
                    "Assets/Images/block15.03.png",
                    "Assets/Images/block15.04.png",
                    "Assets/Images/block15.05.png",
                    "Assets/Images/block15.06.png",
                    "Assets/Images/block15.07.png",
                    "Assets/Images/block15.00.png",
                    }
                },
                //bRicks
                { "r", new List<string>() {
                    "Assets/Images/bricks.png"
                    }
                },
                //Stone blocks
                { "s", new List<string>() {
                    "Assets/Images/stoneBlock01.png"
                    }
                },
                //Pipes
                { "p", new List<string>() {
                    "Assets/Images/pipe01.png"
                    }
                },
                //invisible block for Detection
                { "d", new List<string>() {
                    "Assets/Images/pipe00.png"
                    }
                }
        };

        public static int BRICK_WIDTH = 50;
        public static int BRICK_HEIGHT = 50;
        public static double BRICK_DELAY = 0.5;
        public static int BRICK_RATE = 4;
        public static int BRICK_POINTS = 50;

        // DIALOG
        public static string DIALOG_GROUP = "dialogs";
        public static string ENTER_TO_START = "PRESS ENTER TO START (10$)";
        public static string PREP_TO_LAUNCH = "Let's-a-go!";
        public static string WAS_GOOD_GAME = "GAME OVER";

    }
}