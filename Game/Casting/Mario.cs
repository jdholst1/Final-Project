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
        private bool _isIdle;

        /// <summary>
        /// Constructs our instance of Mario
        /// </summary>
        public Mario(Body body, Animation animation, bool debug) : base(debug)
        {
            this._body = body;
            this._animation = animation;
            this._isIdle = false;
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
            velocity = velocity.AddValues(-Constants.PLUMBER_SPEED, 0);
            // velocity.Friction_x();
            _body.SetVelocity(velocity);
        }

        /// <summary>
        /// Moves Mario to the right.
        /// </summary>
        public void MoveRight()
        {
            // Point velocity = new Point(Constants.PLUMBER_SPEED, _body.GetVelocity().GetY());
            Point velocity = _body.GetVelocity();
            velocity = velocity.AddValues(Constants.PLUMBER_SPEED, 0);
            // velocity.Friction_x();
            _body.SetVelocity(velocity);
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
            velocity = velocity.AddValues(Constants.PLUMBER_SPEED * side * 4, Constants.PLUMBER_JUMP * 2);
            _body.SetVelocity(velocity);
            this._wallJump = false;
        }

        /// <summary>
        /// Makes Mario duck (quack).
        /// </summary>
        public void Duck()
        {
            // Point velocity = new Point(Constants.PLUMBER_SPEED, _body.GetVelocity().GetY());
            _body.SetVelocity(new Point(0, 0));
        }

        /// <summary>
        /// Makes Mario fall
        /// </summary>
        public void Fall()
        {
            Point velocity = _body.GetVelocity();
            // if (_body.GetVelocity().GetY() > -5)
            // {
            //     velocity = velocity.AddValues(0, -1);
            // }
            velocity = velocity.AddValues(0, -1);
            _body.SetVelocity(velocity);
            this._isGrounded++;
        }

        /// <summary>
        /// Makes Mario fall
        /// </summary>
        public bool GetIdle()
        {
            return _isIdle;

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
            }
            else
            {
                new_y = velocity.GetY();
            }
            velocity = velocity.Friction_x(new_x, new_y);
            _body.SetVelocity(velocity);
        }

    }
}