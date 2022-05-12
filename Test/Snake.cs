using System.Collections.Generic;

namespace Snake
{
    class Snake
    {

        private List<Segment> segments;

        public Snake()
        {
            Segment sh = new Segment();
            sh.pos = new Vector2d(1, 0);

            Segment sd = new Segment();
            sd.pos = new Vector2d(0, 0);

            segments = new List<Segment> { sh, sd};
        }

        public void move_segments()
        {
            for (int i = segments.Count - 1; i >= 1; i--)
            {
                segments[i].pos = segments[i - 1].pos;
            }
        }
        public void move_x(int amout)
        {
            move_segments();
            segments[0].pos.update_x(amout);
        }

        public void move_y(int amout)
        {
            move_segments();
            segments[0].pos.update_y(amout);
        }

        public List<Segment> GetSegments()
        {
            return segments;
        }
    }
}