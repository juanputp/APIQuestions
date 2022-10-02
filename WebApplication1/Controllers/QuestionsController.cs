using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Mvc;

namespace QuestionsAPI.Controllers
{
    [Route("api")]
    [ApiController]
    public class QuestionsController : ControllerBase
    {
        public static List<QAnswers> questions = new List<QAnswers>()
        {
            new QAnswers
            {
                Id = 1,
                Q = "¿Qué trilogía de las películas basadas en los cómics de Marvel \n recaudó más dinero en taquilla?",
                A1 = "a. Thor",
                A2 = "b. Capitán América",
                A3 = "c. Iron Man",
                A4 = "d. Wolverine"
            },
            new QAnswers
            {
                Id = 2,
                Q = "¿Cuál de estos planetas está más cercano al sol?",
                A1 = "a. Neptuno",
                A2 = "b. Urano",
                A3 = "c. Saturno",
                A4 = "d. Tierra"
            },
            new QAnswers
            {
                Id = 3,
                Q = "¿Cuál es el océano más grande del mundo?",
                A1 = "a. Océano Pacífico",
                A2 = "b. Océano Índico",
                A3 = "c. Océano Antártico",
                A4 = "d. Océano Atlántico"
            }

        };


        [HttpGet("AllQuestions")]
        public List<QAnswers> Consultar()
        {
            return questions;
        }


        [HttpGet]
        public QAnswers item(int id)
        {
            return questions[0];
        }

        [HttpGet("Question")]
        public dynamic Consultar_id(int id)
        {
            var det = questions.Where(x => x.Id == id).ToList();
            if (det.Count > 0)
            {
                return det;
            }
            else
            {
                return new
                {
                    code = "Api001",
                    message = "No existe registos"
                };
            }
        }



    }
}
