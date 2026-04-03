namespace Program04 {
    public class Result : Exam, Classify {
        public bool Pass(int mark) {
            return mark >= 50;
        }

        public string Division(int average) {
            if (average >= 60) return "First";
            if (average >= 50 && average < 60) return "Second";
            return "No division";
        }
    }
}