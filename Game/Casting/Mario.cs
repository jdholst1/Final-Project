using System.Collections.Generic;

namespace Unit06.Game.Casting
{
    /// <summary>
    /// A thing that participates in the game.
    /// </summary>
    public class Mario : Actor
    {
        private Body _body;
        private Animation _animation;
        private int _isGrounded;
        private bool _wallJump;
        private int _isIdle;
        private int _isFacingRight = 6;
        private List<Animation> _animationsList;
        private bool _ID;

        /// <summary>
        /// Constructs our instance of Mario
        /// </summary>
        public Mario(Body body, bool plumber_ID, bool debug) : base(debug)
        {
            this._ID = plumber_ID;
            if (plumber_ID)
            {
                Animation idle = new Animation(Constants.MARIO_IDLE, Constants.PLUMBER_RATE, 1);
                Animation walking = new Animation(Constants.MARIO_WALK, Constants.PLUMBER_RATE, 1);
                Animation jumping = new Animation(Constants.MARIO_JUMP, Constants.PLUMBER_RATE, 1);
                Animation falling = new Animation(Constants.MARIO_FALL, Constants.PLUMBER_RATE, 1);
                Animation ducking = new Animation(Constants.MARIO_DUCK, Constants.PLUMBER_RATE, 1);
                Animation spinning = new Animation(Constants.MARIO_SPIN, Constants.PLUMBER_RATE, 1);
                Animation idleL = new Animation(Constants.MARIO_IDLE_L, Constants.PLUMBER_RATE, 1);
                Animation walkingL = new Animation(Constants.MARIO_WALK_L, Constants.PLUMBER_RATE, 1);
                Animation jumpingL = new Animation(Constants.MARIO_JUMP_L, Constants.PLUMBER_RATE, 1);
                Animation fallingL = new Animation(Constants.MARIO_FALL_L, Constants.PLUMBER_RATE, 1);
                Animation duckingL = new Animation(Constants.MARIO_DUCK_L, Constants.PLUMBER_RATE, 1);
                this._animationsList = new List<Animation> { idle, walking, jumping, falling, ducking, spinning, idleL, walkingL, jumpingL, fallingL, duckingL };
                this._animation = _animationsList[0];
            }
            else
            {
                Animation idle = new Animation(Constants.LUIGI_IDLE, Constants.PLUMBER_RATE, 1);
                Animation walking = new Animation(Constants.LUIGI_WALK, Constants.PLUMBER_RATE, 1);
                Animation jumping = new Animation(Constants.LUIGI_JUMP, Constants.PLUMBER_RATE, 1);
                Animation falling = new Animation(Constants.LUIGI_FALL, Constants.PLUMBER_RATE, 1);
                Animation ducking = new Animation(Constants.LUIGI_DUCK, Constants.PLUMBER_RATE, 1);
                Animation spinning = new Animation(Constants.LUIGI_SPIN, Constants.PLUMBER_RATE, 1);
                Animation idleL = new Animation(Constants.LUIGI_IDLE_L, Constants.PLUMBER_RATE, 1);
                Animation walkingL = new Animation(Constants.LUIGI_WALK_L, Constants.PLUMBER_RATE, 1);
                Animation jumpingL = new Animation(Constants.LUIGI_JUMP_L, Constants.PLUMBER_RATE, 1);
                Animation fallingL = new Animation(Constants.LUIGI_FALL_L, Constants.PLUMBER_RATE, 1);
                Animation duckingL = new Animation(Constants.LUIGI_DUCK_L, Constants.PLUMBER_RATE, 1);
                this._animationsList = new List<Animation> { idle, walking, jumping, falling, ducking, spinning, idleL, walkingL, jumpingL, fallingL, duckingL };
                this._animation = _animationsList[0];
            }
            this._body = body;
            this._isIdle = 0;
        }

        /// <summary>
        /// Gets the animation.
        /// </summary>
        /// <returns>The animation.</returns>
        public Animation GetAnimation()
        {
            return _animation;
        }

        /// <summary>
        /// Gets the body.
        /// </summary>
        /// <returns>The body.</returns>
        public Body GetBody()
        {
            return _body;
        }

        /// <summary>
        /// Moves Mario to his next position.
        /// </summary>
        public void MoveNext()
        {
            Point position = _body.GetPosition();
            Point velocity = _body.GetVelocity();
            Point newPosition = position.Add(velocity);
            _body.SetPosition(newPosition);
            // velocity.Friction_x();
        }

        /// <summary>
        /// Moves Mario to the left.
        /// </summary>
        public void MoveLeft()
        {
            Point velocity = _body.GetVelocity();
            if (this._isIdle < 0)
            {
                velocity = velocity.AddValues(-Constants.PLUMBER_SPEED, 0);
                // velocity.Friction_x();
                _body.SetVelocity(velocity);
                this._isFacingRight = 6;
            }
        }

        /// <summary>
        /// Moves Mario to the right.
        /// </summary>
        public void MoveRight()
        {
            // Point velocity = new Point(Constants.PLUMBER_SPEED, _body.GetVelocity().GetY());
            Point velocity = _body.GetVelocity();
            if (this._isIdle < 0)
            {
                velocity = velocity.AddValues(Constants.PLUMBER_SPEED, 0);
                // velocity.Friction_x();
                _body.SetVelocity(velocity);
                this._isFacingRight = 0;
            }
        }

        /// <summary>
        /// Makes Mario bounce if he's on the ground.
        /// </summary>
        public void Bounce()
        {
            // Point velocity = new Point(Constants.PLUMBER_SPEED, _body.GetVelocity().GetY());
            Point velocity = _body.GetVelocity();
            velocity = velocity.AddValues(0, Constants.PLUMBER_JUMP);
            _body.SetVelocity(velocity);

        }

        /// <summary>
        /// Makes Mario bounce off of a wall
        /// </summary>
        public void WallKick(int side)
        {
            // Point velocity = new Point(Constants.PLUMBER_SPEED, _body.GetVelocity().GetY());
            Point velocity = new Point(0, Constants.PLUMBER_JUMP);
            velocity = velocity.AddValues(Constants.PLUMBER_SPEED * side * 4, Constants.PLUMBER_JUMP * 4);
            _body.SetVelocity(velocity);
            this._wallJump = false;
            this._isIdle = 20;
        }

        /// <summary>
        /// Makes Mario duck (quack).
        /// </summary>
        public void Duck()
        {
            // Point velocity = new Point(Constants.PLUMBER_SPEED, _body.GetVelocity().GetY());
            _body.SetVelocity(new Point(0, 0));
            this._animation = this._animationsList[4 + this._isFacingRight];
        }

        /// <summary>
        /// Makes Mario fall
        /// </summary>
        public void Fall()
        {
            Point velocity = _body.GetVelocity();
            velocity = velocity.AddValues(0, -1);
            _body.SetVelocity(velocity);
            this._isGrounded++;
            if (this._isGrounded > 5)
            {
                if (velocity.GetY() > 0)
                {
                    this._animation = this._animationsList[3 + this._isFacingRight];
                }
                else
                {
                    this._animation = this._animationsList[2 + this._isFacingRight];
                }
            }
        }

        /// <summary>
        /// Returns if Mario is idle (idle > 0 means he's idle and cannot input controls)
        /// </summary>
        public int GetIdle()
        {
            return _isIdle;
        }

        /// <summary>
        /// Reduces Mario's idle value by 1. This happens each frame.
        /// </summary>
        public void ReduceIdle()
        {
            this._isIdle -= 1;
        }

        /// <summary>
        /// Sets if Mario is on the ground
        /// </summary>
        public void SetGrounded(int toggle)
        {
            this._isGrounded = toggle;
        }

        /// <summary>
        /// Returns if Mario is on the ground
        /// </summary>
        public int GetGrounded()
        {
            return this._isGrounded;
        }

        /// <summary>
        /// Sets if Mario is on the ground
        /// </summary>
        public void SetWall(bool toggle)
        {
            this._wallJump = toggle;
        }

        /// <summary>
        /// Returns if Mario is on the ground
        /// </summary>
        public bool GetWall()
        {
            return this._wallJump;
        }
        /// <summary>
        /// Returns if it's Mario or Luigi
        /// </summary>
        public bool GetID()
        {
            return this._ID;
        }

        /// <summary>
        /// Moves Mario up by one pixel
        /// </summary>
        public void ShiftUp()
        {
            Point position = new Point(0, 0);
            if (_body.GetVelocity().GetY() >= 0)
            {
                position = _body.GetPosition().Add(new Point(0, -1));
            }
            else
            {
                position = _body.GetPosition().Add(new Point(0, 1));
            }
            _body.SetPosition(position);
        }

        /// <summary>
        /// Makes Mario go back if a wall is a vertical wall and not a horizontal platform
        /// </summary>
        public void HitWall(int slope)
        {
            if (_body.GetVelocity().GetY() >= 0)
            {
                slope *= -1;
            }
            Point position = _body.GetPosition().Add(new Point(_body.GetVelocity().GetX() * -1, slope * -1));
            _body.SetPosition(position);
        }

        /// <summary>
        /// Stops Mario from moving in a specified direction.
        /// </summary>
        /// 
        public void StopMoving(bool x, bool y)
        {
            int new_x = _body.GetVelocity().GetX();
            int new_y = _body.GetVelocity().GetY();
            Point velocity = _body.GetVelocity();

            if (x)
            {
                new_x = 0;
            }
            else
            {
                new_x = velocity.GetX();
            }
            if (y)
            {
                new_y = 0;
                if (this.GetBody().GetVelocity().GetX() > 0)
                {
                    this._animation = this._animationsList[1 + this._isFacingRight];
                }
                else
                {
                    this._animation = this._animationsList[0 + this._isFacingRight];
                }
            }
            else
            {
                new_y = velocity.GetY();
            }
            velocity = velocity.Friction_x(new_x, new_y, (this._isGrounded > 4));
            _body.SetVelocity(velocity);
        }
    }
}