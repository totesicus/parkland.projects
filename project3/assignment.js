
console.log("Hello World!");

function main() {
	var parElement = document.createElement("P");
	parElement.innerHTML = "This is Dynamic HTML";
	document.getElementById("container").appendChild(parElement);
};

main();

// use this for part 2 of the assignment

var blogArticles = [{
		title: "Advanced Performance Audits With DevTools",
		author: "Paul Irish",
		publishedOn: "Mar 27th, 2015",
		url: "http://www.paulirish.com/2015/advanced-performance-audits-with-devtools/",
		content: [{
				heading: "",
				paragraph: "In this doc, we look at the scrolling of CNET, input latency on CNET, some very interesting challenges on the responsive Time.com, and infinite scroll on Google Play’s desktop site."
			},{
				heading: "",
				paragraph: "The intended audience is browser engineers and performance-minded frontend developers. It’s fairly advanced, but I’m spelunking deep to identify how the sites butt heads with the browser APIs and architecture."
			},{
				heading: "",
				paragraph: "Lastly, we’re using this research to improve Chrome DevTools and what you hear from Chrome."
			}	
		]
	},{
		title: "Introducing RAIL: A User-Centric Model For Performance",
		author: "Paul Irish & Paul Lewis",
		publishedOn: "10/2/2015",
		url: "http://www.smashingmagazine.com/2015/10/rail-user-centric-model-performance/",
		content: [{
				heading: "Slow",
				paragraph: "Is changing the DOM slow? What about loading a &lt;script&gt; in the &lt;head&gt;? JavaScript animations are slower than CSS ones, right? Also, does a 20-millisecond operation take too long? What about 0.5 seconds? 10 seconds?"
			},{
				heading: "",
				paragraph: "While it’s true that different operations take different amounts of time to complete, it’s hard to say objectively whether something is slow or fast without the context of when it’s happening. For example, code running during idle time, in a touch handler or in the hot path of a game loop each has different performance requirements. Put another way, the people using your website or app have different performance expectations for each of those contexts. Like every aspect of UX, we build for our users, and what they perceive is what matters most. In fact, number one on Google’s ten things we know to be true is “Focus on the user and all else will follow.”"
			},{
				heading: "",
				paragraph: "Asking “What does slow mean?,” then, is really the wrong question. Instead, we need to ask “What does the user feel when they’re interacting with the things we build?”"
			}
		]	
}];

function renderBlogs() {

		for (i = 0; i < blogArticles.length; i++) {
		var currentArticle = blogArticles[i];

		var divArticleWrapper = document.createElement("div");
		divArticleWrapper.className = "article-wrapper";
		
		var articleTitle = document.createElement("h1");
		articleTitle.innerHTML = currentArticle.title;

		var articleAuthor = document.createElement("h4");
		articleAuthor.innerHTML = currentArticle.author;

		var articlePublishedOn = document.createElement("h4");
		articlePublishedOn.innerHTML = currentArticle.publishedOn;

		var articleURL = document.createElement("a");
		var articleText = document.createTextNode(currentArticle.url);
		articleURL.appendChild(articleText);
		articleURL.href = currentArticle.url;
		
		divArticleWrapper.appendChild(articleTitle);
		divArticleWrapper.appendChild(articleAuthor);
		divArticleWrapper.appendChild(articlePublishedOn);
		divArticleWrapper.appendChild(articleURL)
		document.getElementById("blog-container").appendChild(divArticleWrapper);

		var divContentWrapper = document.createElement("div");
				divContentWrapper.className = "content-wrapper";

			for (j = 0; j < currentArticle.content.length; j++) {
				var currentContent = currentArticle.content[j];

				var contentHeading = document.createElement("h2");
				contentHeading.innerHTML = currentContent.heading;

				var contentParagraph = document.createElement("p");
				contentParagraph.innerHTML = currentContent.paragraph;
				
				if (contentHeading.innerHTML === "") {
				divContentWrapper.appendChild(contentParagraph);
				divArticleWrapper.appendChild(divContentWrapper);
				} else {
				divContentWrapper.appendChild(contentHeading);
				divContentWrapper.appendChild(contentParagraph);
				divArticleWrapper.appendChild(divContentWrapper);
				}
			};
	};
}

renderBlogs();