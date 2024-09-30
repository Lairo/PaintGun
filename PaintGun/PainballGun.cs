namespace PaintGun
{
    class PaintBallGun
    {
        private int balls;
        public int MagazineSize { get; private set; }
        public int BallsLoaded { get; private set; }
        public bool IsEmpty
        {
            get { return false; }
            set
            {
                if (BallsLoaded == 0)
                    value = true ; 
            }
        }

        public int Balls
        {
            get { return balls; }
            set
            {
                if (value > 0)
                    balls = value;
                Reload();
            }
        }
        public void Reload()
        {
            if (balls > MagazineSize)
                BallsLoaded = MagazineSize;
            else
                BallsLoaded = balls;
        }

        public bool Shoot()
        {
            if (BallsLoaded == 0) return false;
            BallsLoaded--;
            balls--;
            return true;
        }
        public PaintBallGun(int balls, int magazineSize, bool loaded)
        {
            this.balls = balls;
            MagazineSize = magazineSize;
            if (loaded) Reload();
        }

    }
}

