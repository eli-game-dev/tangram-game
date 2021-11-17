<div dir='rtl' lang='he'>

# tangram-game
 המשחק בנוי על משחק סיני עתיק אשר מורכב מ7 צורות גאומטריות.

חלקי המשחק הם 5 משולשים בגדלים שונים, ריבוע ומקבילית.

ניתן להרכיב באמצעות חלקים אילו מאות צורות.

הטנגרם מסייע בפיתוח החשיבה ושיפור המתמטיקה בתחום הגיאומטרי. 

  * [רכיבים רשמיים](https://github.com/eli-game-dev/tangram-game/blob/main/formal-elements.md)

## Core game loops
itch.io: https://eliyahup.itch.io/tangram-game

במטלה הזאת ממשתי עיצוב ראשוני של המשחק קודם יצרתי את הצורות והגדלים למשל כמו משולש ומקבלית שלא קיימים בעורך של יוניטי.
איך לבנות את המשולש מצאתי באינטרנט ואת כל שאר הצורות עשיתי בעצמי.
[triangleShape](https://github.com/eli-game-dev/tangram-game/blob/main/Assets/scripts/triangleShape.cs)
[Square](https://github.com/eli-game-dev/tangram-game/blob/main/Assets/scripts/Square.cs)
[Parallelogram](https://github.com/eli-game-dev/tangram-game/blob/main/Assets/scripts/Parallelogram.cs)

הוספתי פעמיים את הצורות פעם אחת בשביל הצורות השקופות שאיתם אני בונה את השלב, כלומר את הצורה שהשחקן צריך לבנות,
ופעם אחת את הצורות שהשחקן מזיז בשביל לבנות את הצורה.

הוספתי צבעים לכל הצורות ותאורה.

הוספתי אפשרות שהשחקן יוכל לגרור את הצורות עם העכבר בדומה למה שנלמד בשיעור, בנוסף כאשר המשתמש לוחץ על צורה יראו את הצורה בפרונט 
,בנוסף המשתמש יכול תוך כדי המשחק לסובב את הצורות בעזרת המקשים a,d

[shapeRotate](https://github.com/eli-game-dev/tangram-game/blob/main/Assets/scripts/shapeRotate.cs)
[DragShape](https://github.com/eli-game-dev/tangram-game/blob/main/Assets/scripts/DragShape.cs)


</div>
