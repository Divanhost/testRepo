namespace WorldYachts.Forms
{
    internal class MySqlCommand
    {
        private object query;
        private object conn;

        public MySqlCommand(object query, object conn)
        {
            this.query = query;
            this.conn = conn;
        }
    }
}