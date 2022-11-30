namespace Unit06.Game.Casting
{
    /// <summary>
    /// A thing that participates in the game.
    /// </summary>
    public class Mario : Actor
    {
        private Body _body;
        private Animation _animation;
        private bool _isGrounded;

        /// <summary>
        /// Constructs our instance of Mario
        /// </summary>
        public Mario(Body body, Animation animation, bool debug) : base(debug)
        {
            this._body = body;
            this._animation = animation;
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
        }

        /// <summary>
        /// Moves Mario to the left.
        /// </summary>
        public void MoveLeft()
        {
            Point velocity = _body.GetVelocity();
            velocity = velocity.AddValues(-Constants.PLUMBER_SPEED, 0);
            velocity.Friction_x();
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
            velocity.Friction_x();
            _body.SetVelocity(velocity);
        }

        /// <summary>
        /// Stops Mario from moving in a specified direction.
        /// </summary>
        /// 
        public void StopMoving(bool x, bool y)
        {
            int new_x = _body.GetVelocity().GetX();
            int new_y = _body.GetVelocity().GetY();
            if (x)
            {
                new_x = 0;
            }
            if (y)
            {
                new_y = 0;
            }
            Point velocity = new Point(new_x, new_y);
            _body.SetVelocity(velocity);
        }

    }
}