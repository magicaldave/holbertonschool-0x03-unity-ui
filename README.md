# 0x02. Unity - Scripting
<h3 class="panel-title">Concepts</h3>
<div class="panel-body">
<p>
    <em>For this project, we expect you to look at this concept:</em>
</p>

<ul>
    <li>
        <a href="https://intranet.hbtn.io/concepts/785">Unity WebGL Builds</a>
    </li>
</ul>
</div>
<div class="panel panel-default" id="project-description">
    <div class="panel-body">
	<h2>Resources</h2>

<p><strong>Read or watch</strong>:</p>

<ul>
<li><a href="https://intranet.hbtn.io/rltoken/ANWMowPA6XvLoalZeNK1XQ" title="Unity Manual: Scripting Overview" target="_blank">Unity Manual: Scripting Overview</a> (<em>Read sections from “Creating and Using Scripts” to “Understanding Automatic Memory Management”</em>)</li>
<li><a href="https://intranet.hbtn.io/rltoken/s-k_6zkcddiVZrtrwzHavQ" title="Scripts as Behavior Components" target="_blank">Scripts as Behavior Components</a> </li>
<li><a href="https://intranet.hbtn.io/rltoken/7R2Y5ZO0-HVd9IC2b9rL8Q" title="How to make a Video Game in Unity - Programming" target="_blank">How to make a Video Game in Unity - Programming</a> </li>
<li><a href="https://intranet.hbtn.io/rltoken/t71Y3Rc-l5VUGGC1fURIPA" title="How to make a Video Game in Unity - Movement" target="_blank">How to make a Video Game in Unity - Movement</a> </li>
<li><a href="https://intranet.hbtn.io/rltoken/mfuUkC38TvCW8wko-dZJoA" title="How to make a Video Game in Unity - Camera Follow" target="_blank">How to make a Video Game in Unity - Camera Follow</a> </li>
<li><a href="https://intranet.hbtn.io/rltoken/Fcrw_-suu9rkU66-bbfuuw" title="Vector Maths" target="_blank">Vector Maths</a> </li>
<li><a href="https://intranet.hbtn.io/rltoken/CMlNwGX7epVyx4BDkncpqw" title="What Makes Great Games Great?" target="_blank">What Makes Great Games Great?</a> </li>
<li><a href="https://intranet.hbtn.io/rltoken/Pj_jBqj-JKQqsl06Kk0qSw" title="Unity Manual" target="_blank">Unity Manual</a> </li>
<li><a href="https://intranet.hbtn.io/rltoken/JDSsD1C_p8XUflliUbwMrA" title="Unity Tutorials: Scripting" target="_blank">Unity Tutorials: Scripting</a> </li>
<li><a href="https://intranet.hbtn.io/rltoken/Vjp-h0U9kMKBUmihFNOUfg" title="Unity Manual: Vector3" target="_blank">Unity Manual: Vector3</a> </li>
</ul>

<h2>Learning Objectives</h2>

<p>At the end of this project, you are expected to be able to <a href="https://intranet.hbtn.io/rltoken/DV8i_2N5-xym-lSBEAW2Vw" title="explain to anyone" target="_blank">explain to anyone</a>, <strong>without the help of Google</strong>:</p>

<h3>General</h3>

<ul>
<li>What are scripts in Unity and how are they created and used</li>
<li>How to control GameObjects with scripts</li>
<li>What is an event function and how are the most common ones used</li>
<li>How to create and destroy GameObjects within scripts</li>
<li>How to use namespaces to organize classes</li>
<li>What are attributes and how to use them</li>
<li>How to use <code>Debug.Log()</code></li>
<li>What is a vector</li>
</ul>

<h2>Requirements</h2>

<h3>General</h3>

<ul>
<li>A <code>README.md</code> file, at the root of the folder of the project</li>
<li>Use Unity’s default <a href="https://intranet.hbtn.io/rltoken/fN1oCOENyvwGtR0-yulHhg" title=".gitignore" target="_blank">.gitignore</a> in your project folder</li>
<li>Push the entire repo <code>0x02-unity-scripting</code>, including <code>.meta</code> files</li>
<li>Scenes and project assets such as Materials must be named and organized as described in the tasks</li>
</ul>

  </div>
</div>

<div class="panel-heading">
    <h3 class="panel-title">
        Quiz questions
    </h3>
</div>
    <h4 class="quiz_question">
        
        Question #0
    </h4>

    <!-- Quiz question Body -->
    <p>What is MonoBehaviour?</p>


    <!-- Quiz question Answers -->
        <ul class="quiz_question_answers" data-question-id="4798">
                <li class="">

  <input type="radio" name="4798" id="4798-1520561932541" value="1520561932541" data-quiz-answer-id="1520561932541" data-quiz-question-id="4798" disabled="disabled">
  <label for="4798-1520561932541"><p>A programming paradigm for games</p>
</label>
</li>

                <li class="">

  <input type="radio" name="4798" id="4798-1520561933690" value="1520561933690" data-quiz-answer-id="1520561933690" data-quiz-question-id="4798" disabled="disabled" checked="checked">
  <label for="4798-1520561933690"><p>The base class from which every Unity script derives</p>
</label>
</li>

                <li class="">

  <input type="radio" name="4798" id="4798-1520561934775" value="1520561934775" data-quiz-answer-id="1520561934775" data-quiz-question-id="4798" disabled="disabled">
  <label for="4798-1520561934775"><p>A method of assigning behavior to an object</p>
</label>
</li>

        </ul>

    <!-- Quiz question Tips -->

</div>

</div>
          <div class="quiz_question_item_container" data-role="quiz_question4799" data-position="2">
            <div class=" clearfix" id="quiz_question-4799">

    <h4 class="quiz_question">
        
        Question #1
    </h4>

    <!-- Quiz question Body -->
    <p>When is <code>void Update()</code> called?</p>


        <ul class="quiz_question_answers" data-question-id="4799">
                <li class="">

  <input type="radio" name="4799" id="4799-1520562006292" value="1520562006292" data-quiz-answer-id="1520562006292" data-quiz-question-id="4799" disabled="disabled" checked="checked">
  <label for="4799-1520562006292"><p>Once every frame</p>
</label>
</li>

                <li class="">

  <input type="radio" name="4799" id="4799-1520562011926" value="1520562011926" data-quiz-answer-id="1520562011926" data-quiz-question-id="4799" disabled="disabled">
  <label for="4799-1520562011926"><p>When a change is made to the object the script is attached to</p>
</label>
</li>

                <li class="">

  <input type="radio" name="4799" id="4799-1520562036822" value="1520562036822" data-quiz-answer-id="1520562036822" data-quiz-question-id="4799" disabled="disabled">
  <label for="4799-1520562036822"><p>Once per game</p>
</label>
</li>

        </ul>

    <!-- Quiz question Tips -->

</div>

          </div>
          <div class="quiz_question_item_container" data-role="quiz_question4800" data-position="3">
            <div class=" clearfix" id="quiz_question-4800">

    <h4 class="quiz_question">
        
        Question #2
    </h4>

    <!-- Quiz question Body -->
    <p>A script’s class name and file name must be the same to allow the script to be attached to a GameObject.</p>


    <!-- Quiz question Answers -->
        <ul class="quiz_question_answers" data-question-id="4800">
                <li class="">

  <input type="radio" name="4800" id="4800-1520562320211" value="1520562320211" data-quiz-answer-id="1520562320211" data-quiz-question-id="4800" disabled="disabled" checked="checked">
  <label for="4800-1520562320211"><p>True</p>
</label>
</li>

                <li class="">

  <input type="radio" name="4800" id="4800-1520562352044" value="1520562352044" data-quiz-answer-id="1520562352044" data-quiz-question-id="4800" disabled="disabled">
  <label for="4800-1520562352044"><p>False</p>
</label>
</li>

        </ul>

    <!-- Quiz question Tips -->

</div>

          </div>
          <div class="quiz_question_item_container" data-role="quiz_question4801" data-position="4">
            <div class=" clearfix" id="quiz_question-4801">

    <h4 class="quiz_question">
        
        Question #3
    </h4>

    <!-- Quiz question Body -->
    <p>How can you allow your script’s variable values to be edited from Unity’s Inspector window?</p>


    <!-- Quiz question Answers -->
        <ul class="quiz_question_answers" data-question-id="4801">
                <li class="">

  <input type="checkbox" name="4801" id="4801-1520562366175" value="1520562366175" data-quiz-answer-id="1520562366175" data-quiz-question-id="4801" disabled="disabled">
  <label for="4801-1520562366175"><p>Add an a <code>ShowInInspector</code> attribute</p>
</label>
</li>

                <li class="">

  <input type="checkbox" name="4801" id="4801-1520562367307" value="1520562367307" data-quiz-answer-id="1520562367307" data-quiz-question-id="4801" disabled="disabled" checked="checked">
  <label for="4801-1520562367307"><p>Declare the variable as <code>public</code></p>
</label>
</li>

                <li class="">

  <input type="checkbox" name="4801" id="4801-1520562368804" value="1520562368804" data-quiz-answer-id="1520562368804" data-quiz-question-id="4801" disabled="disabled" checked="checked">
  <label for="4801-1520562368804"><p>Add a <code>SerializeField</code> attribute for private variables</p>
</label>
</li>

        </ul>

    <!-- Quiz question Tips -->

</div>

          </div>
          <div class="quiz_question_item_container" data-role="quiz_question4802" data-position="5">
            <div class=" clearfix" id="quiz_question-4802">

    <h4 class="quiz_question">
        
        Question #4
    </h4>

    <!-- Quiz question Body -->
    <p>A Component is an instance of a class.</p>


    <!-- Quiz question Answers -->
        <ul class="quiz_question_answers" data-question-id="4802">
                <li class="">

  <input type="radio" name="4802" id="4802-1520562503330" value="1520562503330" data-quiz-answer-id="1520562503330" data-quiz-question-id="4802" disabled="disabled" checked="checked">
  <label for="4802-1520562503330"><p>True</p>
</label>
</li>

                <li class="">

  <input type="radio" name="4802" id="4802-1520562517036" value="1520562517036" data-quiz-answer-id="1520562517036" data-quiz-question-id="4802" disabled="disabled">
  <label for="4802-1520562517036"><p>False</p>
</label>
</li>

        </ul>

    <!-- Quiz question Tips -->

</div>

          </div>
          <div class="quiz_question_item_container" data-role="quiz_question4803" data-position="6">
            <div class=" clearfix" id="quiz_question-4803">

    <h4 class="quiz_question">
        
        Question #5
    </h4>

    <!-- Quiz question Body -->
    <p>A GameObject can have more than one custom script attached to it.</p>


    <!-- Quiz question Answers -->
        <ul class="quiz_question_answers" data-question-id="4803">
                <li class="">

  <input type="radio" name="4803" id="4803-1520562522611" value="1520562522611" data-quiz-answer-id="1520562522611" data-quiz-question-id="4803" disabled="disabled" checked="checked">
  <label for="4803-1520562522611"><p>True</p>
</label>
</li>

                <li class="">

  <input type="radio" name="4803" id="4803-1520562527088" value="1520562527088" data-quiz-answer-id="1520562527088" data-quiz-question-id="4803" disabled="disabled">
  <label for="4803-1520562527088"><p>False</p>
</label>
</li>

        </ul>

    <!-- Quiz question Tips -->

</div>

          </div>
          <div class="quiz_question_item_container" data-role="quiz_question4804" data-position="7">
            <div class=" clearfix" id="quiz_question-4804">

    <h4 class="quiz_question">
        
        Question #6
    </h4>

    <!-- Quiz question Body -->
    <p>What function creates a new GameObject?</p>


    <!-- Quiz question Answers -->
        <ul class="quiz_question_answers" data-question-id="4804">
                <li class="">

  <input type="radio" name="4804" id="4804-1520563003596" value="1520563003596" data-quiz-answer-id="1520563003596" data-quiz-question-id="4804" disabled="disabled">
  <label for="4804-1520563003596"><p><code>Create()</code></p>
</label>
</li>

                <li class="">

  <input type="radio" name="4804" id="4804-1520563024412" value="1520563024412" data-quiz-answer-id="1520563024412" data-quiz-question-id="4804" disabled="disabled">
  <label for="4804-1520563024412"><p><code>New()</code></p>
</label>
</li>

                <li class="">

  <input type="radio" name="4804" id="4804-1520563026127" value="1520563026127" data-quiz-answer-id="1520563026127" data-quiz-question-id="4804" disabled="disabled" checked="checked">
  <label for="4804-1520563026127"><p><code>Instantiate()</code></p>
</label>
</li>

        </ul>

    <!-- Quiz question Tips -->

</div>

          </div>
          <div class="quiz_question_item_container" data-role="quiz_question4805" data-position="8">
            <div class=" clearfix" id="quiz_question-4805">

    <h4 class="quiz_question">
        
        Question #7
    </h4>

    <!-- Quiz question Body -->
    <p>What function deletes a GameObject?</p>


    <!-- Quiz question Answers -->
        <ul class="quiz_question_answers" data-question-id="4805">
                <li class="">

  <input type="radio" name="4805" id="4805-1520563038959" value="1520563038959" data-quiz-answer-id="1520563038959" data-quiz-question-id="4805" disabled="disabled" checked="checked">
  <label for="4805-1520563038959"><p><code>Destroy()</code></p>
</label>
</li>

                <li class="">

  <input type="radio" name="4805" id="4805-1520563044533" value="1520563044533" data-quiz-answer-id="1520563044533" data-quiz-question-id="4805" disabled="disabled">
  <label for="4805-1520563044533"><p><code>Delete()</code></p>
</label>
</li>

                <li class="">

  <input type="radio" name="4805" id="4805-1520563048359" value="1520563048359" data-quiz-answer-id="1520563048359" data-quiz-question-id="4805" disabled="disabled">
  <label for="4805-1520563048359"><p><code>Remove()</code></p>
</label>
</li>

        </ul>

    <!-- Quiz question Tips -->

</div>

          </div>
          <div class="quiz_question_item_container" data-role="quiz_question4806" data-position="9">
            <div class=" clearfix" id="quiz_question-4806">

    <h4 class="quiz_question">
        
        Question #8
    </h4>

    <!-- Quiz question Body -->
    <p>Which of the following is a correctly formatted attribute in C#?</p>


    <!-- Quiz question Answers -->
        <ul class="quiz_question_answers" data-question-id="4806">
                <li class="">

  <input type="radio" name="4806" id="4806-1520563089512" value="1520563089512" data-quiz-answer-id="1520563089512" data-quiz-question-id="4806" disabled="disabled">
  <label for="4806-1520563089512"><p><code>@HideInInspector</code></p>
</label>
</li>

                <li class="">

  <input type="radio" name="4806" id="4806-1520563105179" value="1520563105179" data-quiz-answer-id="1520563105179" data-quiz-question-id="4806" disabled="disabled" checked="checked">
  <label for="4806-1520563105179"><p><code>[HideInInspector]</code></p>
</label>
</li>

                <li class="">

  <input type="radio" name="4806" id="4806-1520563113095" value="1520563113095" data-quiz-answer-id="1520563113095" data-quiz-question-id="4806" disabled="disabled">
  <label for="4806-1520563113095"><p><code>// HideInInspector</code></p>
</label>
</li>

        </ul>

    <!-- Quiz question Tips -->

</div>

          </div>
          <div class="quiz_question_item_container" data-role="quiz_question4807" data-position="10">
            <div class=" clearfix" id="quiz_question-4807">

    <h4 class="quiz_question">
        
        Question #9
    </h4>

    <!-- Quiz question Body -->
    <p>What is a vector?</p>


    <!-- Quiz question Answers -->
        <ul class="quiz_question_answers" data-question-id="4807">
                <li class="">

  <input type="radio" name="4807" id="4807-1520563130103" value="1520563130103" data-quiz-answer-id="1520563130103" data-quiz-question-id="4807" disabled="disabled">
  <label for="4807-1520563130103"><p>A fixed point in space</p>
</label>
</li>

                <li class="">

  <input type="radio" name="4807" id="4807-1520563131432" value="1520563131432" data-quiz-answer-id="1520563131432" data-quiz-question-id="4807" disabled="disabled" checked="checked">
  <label for="4807-1520563131432"><p>An object that has both a magnitude and a direction</p>
</label>
</li>

                <li class="">

  <input type="radio" name="4807" id="4807-1520563133173" value="1520563133173" data-quiz-answer-id="1520563133173" data-quiz-question-id="4807" disabled="disabled">
  <label for="4807-1520563133173"><p>A line drawn between two points</p>
</label>
</li>

        </ul>

    <!-- Quiz question Tips -->

</div>

          </div>

      </section>
    </div>
  </div>
