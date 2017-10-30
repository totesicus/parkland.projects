
import java.util.Scanner;

public class Quiz {
	
	private int score;
	private Question[] questionHolder = new Question[3];
	private int numQuestions;
	
	public Quiz() 
	{
		this.score = 0;
		this.numQuestions = 0;
	}
	
	public void addQuestion(Question Q)
	{
		this.questionHolder[numQuestions++] = Q;
	}
	
	public int giveQuiz() 
	{
		Scanner scan = new Scanner(System.in);
		
		String candidateAnswer;
		
		System.out.println(questionHolder[0]);
		candidateAnswer = scan.nextLine();
		
		System.out.println(questionHolder[1]);
		candidateAnswer = scan.nextLine();
		
		System.out.println(questionHolder[2]);
		candidateAnswer = scan.nextLine();
		
		for (int i = 0; i < numQuestions; i++)
		{
			candidateAnswer = scan.nextLine();
			if (questionHolder[i].answerCorrect(candidateAnswer))
				score++;
			else
				System.out.println("Incorrect");
		}
		
		return getScore();
	}
	
		public int getScore() 
		{
			return score;
		}
		
		public String toString() 
		{
			return getScore() + "\n";
		}
		
	}

