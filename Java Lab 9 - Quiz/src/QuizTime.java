
public class QuizTime {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		Question Q1, Q2, Q3;
		
		Quiz quiz1;
		
		Q1 = new Question("Who is Luke Skywalker's father?", "Darth Vader");
		Q2 = new Question("What program are we using in CSC 140?", "Eclipse");
		Q3 = new Question("What city is Parkland College located in?", "Champaign");
		
		quiz1 = new Quiz();
		quiz1.addQuestion(Q1);
		quiz1.addQuestion(Q2);
		quiz1.addQuestion(Q3);
		
		System.out.println(quiz1.giveQuiz());

	}

}
